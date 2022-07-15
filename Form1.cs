using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApi;
using System.Xml;
using System.Globalization;
//79005
namespace WeatherAppp
{
    public partial class Form1 : Form
    {

        public List<string> SearchHistory = new List<string>();
        public string Item = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            string feedebackW = WeatherReader.GetWeather(tbTown.Text);


            
           if (!String.IsNullOrEmpty(feedebackW))
            {
                GetAndPasteData(feedebackW);
                Item = tbTown.Text;
                SearchHistory.Add(Item);
            }
            else
            {
                MessageBox.Show("Incorrect data. Please, try again");
            }

            //------------------
            string feedebackF = WeatherReader.GetForecast(tbTown.Text);
            if (!String.IsNullOrEmpty(feedebackF))
            {
                GetAndPasteForecastData(feedebackF);
                GetAndPasteData(feedebackW);
            }
            else
            {
                MessageBox.Show("Incorrect data. Please, try again");
            }

           
        }
        public void GetAndPasteData(string fb)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(fb);
            XmlElement xroot = document.DocumentElement;
            foreach (XmlElement xchild in xroot)
            {
                if (xchild.Name == "city")
                {
                    XmlNode attr = xchild.Attributes.GetNamedItem("name");
                    if (attr != null)
                        lbCity.Text = "City: " + attr.Value;

                    foreach (XmlElement xchildchild in xchild)
                    {
                        if (xchildchild.Name == "country")
                        {
                            lbCountry.Text = xchildchild.InnerXml;

                        }
                    }
                    foreach (XmlElement xchildcoord in xchild)
                    {
                        if (xchildcoord.Name == "coord")
                        {
                            XmlNode attlon = xchildcoord.Attributes.GetNamedItem("lon");
                            XmlNode attlat = xchildcoord.Attributes.GetNamedItem("lat");

                            if (attlon != null)
                                lbLon.Text = attlon.Value;
                            if (attlat != null)
                                lbLat.Text = attlat.Value;
                        }
                    }
                }
                if (xchild.Name == "temperature")
                {
                    XmlNode attmax = xchild.Attributes.GetNamedItem("max");
                    XmlNode attmin = xchild.Attributes.GetNamedItem("min");
                    if (attmax != null)
                        lbMaxT.Text = attmax.Value;
                    if (attmin != null)
                        lbMinT.Text = attmin.Value;

                }
                if (xchild.Name == "wind")
                    foreach (XmlElement xchildwind in xchild)
                    {
                        if (xchildwind.Name == "speed")
                        {
                            XmlNode attspeed = xchildwind.Attributes.GetNamedItem("value");
                            if (attspeed != null)
                                lbWind.Text = "Wind speed:" + attspeed.Value;
                        }
                    }
                if (xchild.Name == "clouds")
                {
                    XmlNode attclouds = xchild.Attributes.GetNamedItem("name");
                    if (attclouds != null)
                        lbClouds.Text = attclouds.Value;
                }

            }
        }

      

        public void GetAndPasteForecastData(string fb)
        {
            DateTime from;
            DateTime to;
            string min = "";
            string max = "";
            string wind = "";
            string clouds = "";
            string numberwind = "";
            string numberclouds = "";
            string pressure = "";



            XmlDocument document = new XmlDocument();
            document.LoadXml(fb);
            XmlElement xroot = document.DocumentElement;
            foreach (XmlElement xchild in xroot)
            {
                if (xchild.Name == "forecast")
                {
                    foreach (XmlElement xchildchild in xchild)
                    {
                        if (xchildchild.Name == "time")
                        {
                            from = DateTime.Parse(xchildchild.Attributes.GetNamedItem("from").Value,
                                null, DateTimeStyles.AssumeUniversal);
                            to = DateTime.Parse(xchildchild.Attributes.GetNamedItem("to").Value,
                                null, DateTimeStyles.AssumeUniversal);
                            
                            
                            foreach(XmlElement xchildtime in xchildchild)
                            {
                                if (xchildtime.Name == "temperature")
                                {
                                    min = xchildtime.Attributes.GetNamedItem("min").Value;
                                    max = xchildtime.Attributes.GetNamedItem("max").Value;

                                }
                                if (xchildtime.Name == "windSpeed")
                                {
                                    wind = xchildtime.Attributes.GetNamedItem("name").Value;
                                    numberwind = xchildtime.Attributes.GetNamedItem("mps").Value;
                                }
                                if (xchildtime.Name == "clouds")
                                {
                                    clouds = xchildtime.Attributes.GetNamedItem("value").Value;
                                    numberclouds = xchildtime.Attributes.GetNamedItem("all").Value;

                                }
                                if (xchildtime.Name == "pressure")
                                {
                                    pressure = xchildtime.Attributes.GetNamedItem("value").Value;
                                }
                            }

                            dgForecast.Rows.Add(
                             from.DayOfWeek.ToString(),
                             from.ToShortTimeString() + "-" + to.ToShortTimeString(),
                             min,
                             max,
                             wind,
                             clouds,
                             numberwind,
                             numberclouds,
                             pressure);

                        }
                       
                    }
                  
                }
            }
        }

        private void tbZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgForecast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History form = new History(SearchHistory);
            form.ShowDialog();
        }
    }
}
