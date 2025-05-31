
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace myweather
{
    public partial class Form1 : Form
    {
        private string key = System.Configuration.ConfigurationManager.AppSettings["key"].ToString();
        private string baseUrl = System.Configuration.ConfigurationManager.AppSettings["BaseUrl"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGET_Click(object sender, EventArgs e)
        {
            string city = txtCITY.Text;
            using (HttpClient client = new HttpClient())
            {
                lblDETAILS.Text = "wait......";
                string url = baseUrl + $"weather?q={city}&appid={key}&units=metric";
                string response = await client.GetStringAsync(url);
                var node = JsonNode.Parse(response);
                lblDETAILS.Text = "temp:" + node["main"]["temp"].ToString() + "C" + Environment.NewLine +
                    "Humidity:" + node["main"]["humidity"].ToString();
            }
        }
    }
}
