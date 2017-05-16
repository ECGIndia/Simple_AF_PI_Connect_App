using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OSIsoft.AF.PI; // To connect to PI Data Archive
using OSIsoft.AF.Asset;// To Get Data of PI tag
using OSIsoft.AF.Search;// To search elements based on query

using OSIsoft.AF;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {        
        PIServers PIDataArchives = null; // Group of PI Data Archives
        PIServer myPIDataArchive = null; // PI Data Archive
        PIPoint myTag = null; // PI Tag
        AFValue myTagValue = null; // PI Tag Value

        PISystems AFServers = null; // Group of AF Servers
        PISystem AFServer = null; // AF Server
        AFDatabase myAFDB = null; // AF Database
        AFAttribute myAttribute = null; // AF Attribute
        List<AFAttribute> myAttributes = null; // List of AF Attributes

        //AFNamedCollectionList<AFElement> allChildElements = new AFNamedCollectionList<AFElement>();
        
        public Form1()
        {
            InitializeComponent();
            PIDataArchives = new PIServers(); // Get Group of PI Data Archives
            AFServers = new PISystems(); // Get AF Server
        }

        // Connect to PI Data Archive (PI Server in older terminology)
        private void button1_Click(object sender, EventArgs e)
        {
            myPIDataArchive = PIDataArchives[txtPIServer.Text];

            try
            {
                myPIDataArchive.Connect(true, null);
                MessageBox.Show("Connected to PI Data Archive");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PI Data Archive Connect Error : "+ex.Message);
            }                
        }

        // Find PI Tag from PI Data Archive
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myTag = PIPoint.FindPIPoint(myPIDataArchive, txtTagName.Text); // Find PI Tag within PI Data Archive
            }
            catch (Exception ex)
            {
                MessageBox.Show("PI Tag Error : " + ex.Message);
            }

            if (myTag != null)
            {
                myTagValue = myTag.Snapshot(); // Find Current Value
                txtTagValue.Text = myTagValue.ToString();
            }

        }

        // Exit Application
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Connect AF Server
        private void button4_Click(object sender, EventArgs e)
        {            
            if (txtAFServer.Text != null)
                AFServer = AFServers[txtAFServer.Text]; // AF Server name
            else
                MessageBox.Show("Enter AF Server name");
            try
            {
                AFServer.Connect(); // Connect to AF Server
                lblAFStatus.Text = "AF Server " + txtAFServer.Text + " Connected !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to AF Server:"+txtAFServer.Text);
            }            
        }


        // Get PIPoint related to AF Attribute
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to AF Attribute
                //myAttribute = AFAttribute.FindAttribute("\\\\ECGPISERVER\\Portal_DB\\Garima\\Generation\\Wind|Asset Availability", myAFDB);
                myAttribute = AFAttribute.FindAttribute(txtAttribute.Text, myAFDB);
                txtAttributeValue.Text = myAttribute.PIPoint.ToString();
                
                // Load PI Point Attributes: pass null to load all attributes of PI Point
                myAttribute.PIPoint.LoadAttributes("engunits");
                object drAttrValue; // store neg. units output
                drAttrValue = myAttribute.PIPoint.GetAttribute("engunits"); // Get UoM of PI Point
                txtAttributeValue.Text += " UoM:"+drAttrValue.ToString();


                // Learning Efforts
                //IEnumerable<string> list = myAttribute.PIPoint.FindAttributeNames(null);
                //foreach (string item in list) {
                //    drAttrValue = myAttribute.PIPoint.GetAttribute(item);
                //    Console.WriteLine("  {0} = '{1}'", item, drAttrValue);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("AF Server Connection Exception: " + ex.Message);
            }
            
        }

        // Connect to AF Databae
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                myAFDB = AFServer.Databases[txtAFDB.Text]; // Connect to AF Database
                if(myAFDB == null)
                {
                    MessageBox.Show("No such AF database "+txtAFDB.Text+" found in Af Server:"+AFServer.ToString());
                }
                lblDBStatus.Text = "Connected to AF DB: "+txtAFDB.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AF Server Connection Exception: " + ex.Message);
            }
            
        }

        // Find Attributes of Element
        // Element is given by path
        private void button8_Click(object sender, EventArgs e)
        {
            // Learning efforts
            //myAttributes = AFAttribute.FindAttributes(@"Garima\Generation\Solar", myAFDB) as List<AFAttribute>;
            //AFElement.FindElementsByPath(@"Garima\Generation\Solar", myAFDB);

            // Path array contain paths of Element
            string[] path = new string[1];
            //path[0] = "\\\\ECGPISERVER\\Portal_DB\\Garima\\Generation\\Wind";
            path[0] = txtElementbyPath.Text;

            try
            {
                // Find Elements by Path
                AFKeyedResults<string, AFElement> foundElements = null;
                foundElements = AFElement.FindElementsByPath(path, myAFDB);

                // Find attributes of element
                AFElement AfEle = foundElements[path[0]];
                AFAttributes attrList = AfEle.Attributes;

                AFValue[] afValues = new AFValue[attrList.Count];

                // Find values of all attributes                
                List<string> _attributes = new List<string>();
                foreach (AFAttribute item in attrList)
                {
                    _attributes.Add(item.Name);
                }
                lstAttributes.DataSource = _attributes;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Find Immediate Child Elements of given Element by Name
        private void button7_Click(object sender, EventArgs e)
        {
            List<string> _childEle = new List<string>(); // Input list to store all elements
            List<string> _uniqueEle = new List<string>(); //Output list to store unique elemnts
           
            // Parameters: Element Name, Input empty list, boolean value 
            // Boolean value -> True : Add all child elements
            //                  False: Add only immediate child elements
            _uniqueEle=findAllChildElements(txtElementName.Text, _childEle, false);
            // Assigning unique immediate child
            lstChildElements.DataSource = _uniqueEle;
        }


        private List<string> findAllChildElements(string EleName, List<string> _childEle, bool addAllChild)
        {
            try
            {
                // Learning Efforts
                //AFElementSearch search = new AFElementSearch(myAFDB, "FindChildElements", @"Root:'Garima\Generation' Template:'*Area*' Parent:'"+txtElementName.Text+"'");
                //AFElementSearch search = new AFElementSearch(myAFDB, "FindChildElements", @"Root:'Garima\Generation' Name:'" + EleName + "'");                

                AFElementSearch search = new AFElementSearch(myAFDB, "FindChildElements", @"Root:'Garima' Name:'" + EleName + "'");
                search.CacheTimeout = TimeSpan.FromMinutes(10);
                
                // Learning Efforts
                //int count = search.GetTotalCount();
                // Find values of all attributes
                //int i = 0;
                //string templateName = null;
                //List<string> _childEle = new List<string>();
                //_childEle = null;
                //AFElements childelms = item.Elements;
                //foreach (AFElement elm in childelms)
                //{
                //    //Console.WriteLine("ChildElement {0}", elm.Name);
                //    _childEle.Add(elm.Name);
                //    templateName = elm.Template.ToString();
                //    if (elm.HasChildren)
                //    {
                //        if (templateName.Contains("Site Template"))
                //            return;
                //        findAllChildElements(elm.Name, _childEle);
                //    }
                //}

                if (addAllChild) {

                    // Add all child elements
                    foreach (AFElement item in search.FindElements(fullLoad: true))
                    {
                        addChildElements(item, _childEle);
                    }
                }
                else {

                    // Add immediate child elements
                    foreach (AFElement item in search.FindElements(fullLoad: true)) {
                        addChildElement(item, _childEle);
                    }
                }
                    
                    return _childEle.Distinct().ToList(); // return only unique entries of list

                // Learning Efforts
                //return _childEle;
                //lstChildElements.DataSource = _childEle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }            
        }

        // Find all child elements to the parent
        private void addChildElements(AFElement item, List<string> _childEle)
        {
            AFElements childElms = item.Elements; // Find all immediate child elements
            string templateName = null; // variable to hold template name

            // Looping through all immediate child elements
            foreach (AFElement elm in childElms)
            {
                //Console.WriteLine("ChildElement {0}", elm.Name);
                _childEle.Add(elm.Name); // Add element name into list
                templateName = elm.Template.ToString(); // Get template name of element

                if (elm.HasChildren) // Go to deep into hierarchy if element has children
                {
                    if (templateName.Contains("Site Template")) // Stop recursive call if element template contain * Site Template
                        continue;
                    addChildElements(elm, _childEle); // recursive calls to add child elements into list
                }
            }
        }

        // Find only immediate element to the parent
        private void addChildElement(AFElement item, List<string> _childEle)
        {
            AFElements childElms = item.Elements; // Find all immediate child elements

            // Looping through all immediate child elements
            foreach (AFElement elm in childElms)
            {
                //Console.WriteLine("ChildElement {0}", elm.Name);
                _childEle.Add(elm.Name); // Add element name into list       
            }
        }

        // Get all child names of Element given by name
        private void button9_Click(object sender, EventArgs e)
        {
            List<string> _childEle = new List<string>(); // Input list to store all elements
            List<string> _uniqueEle = new List<string>(); // Output list to store unique elements

            // Parameters: Element Name, Input empty list, boolean value 
            // Boolean value -> True : Add all child elements
            //                  False: Add only immediate child elements
            _uniqueEle = findAllChildElements(txtElementName_all.Text, _childEle, true);
            lstAllChildElements.DataSource = _uniqueEle; // Assigning unique all child elements
        }
    }

}
