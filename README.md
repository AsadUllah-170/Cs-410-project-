# Cs-410-project-
**APP.CONFIG file**
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
	<appSettings>
		<add key="key" value="755d56637be37bccfa901f54603d2cae" />
		<add key="BaseUrl" value="https://api.openweathermap.org/data/2.5/" />
	</appSettings>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="System.Memory" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.0.2.0" newVersion="4.0.2.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Threading.Tasks.Extensions" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.2.4.0" newVersion="4.2.4.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-6.0.3.0" newVersion="6.0.3.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>

**Forms.cs file**
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




