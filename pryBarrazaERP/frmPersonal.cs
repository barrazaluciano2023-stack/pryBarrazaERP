using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace pryBarrazaERP
{
    public partial class frmPersonal : Form
    {
        public string Latitud { get; set; }
        public string Longitud { get; set; }

        public frmPersonal()
        {
            InitializeComponent();
            InicializarMapa();
        }
        

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            
        }
        private async void InicializarMapa()
        {
            await wbvGeo.EnsureCoreWebView2Async(null);

            string html = @"
            <!DOCTYPE html>
            <html>
            <head>

                <meta charset='utf-8'/>

                <link rel='stylesheet'
                href='https://unpkg.com/leaflet/dist/leaflet.css'/>

                <script src='https://unpkg.com/leaflet/dist/leaflet.js'></script>

                <style>
                    html, body {
                        height:100%;
                        margin:0;
                    }

                    #map {
                        width:100%;
                        height:100%;
                    }
                </style>

            </head>

            <body>

                <div id='map'></div>

                <script>

                    var map = L.map('map').setView([-31.4201, -64.1888], 13);

                    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                        attribution: 'OpenStreetMap'
                    }).addTo(map);

                    var marker;

                    map.on('click', function(e){

                        if(marker){
                            map.removeLayer(marker);
                        }

                        marker = L.marker(e.latlng).addTo(map);

                        chrome.webview.postMessage(
                            e.latlng.lat + ',' + e.latlng.lng
                        );
                    });

                </script>

            </body>
            </html>";

            wbvGeo.NavigateToString(html);

            wbvGeo.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void CoreWebView2_WebMessageReceived(object sender,
            Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string[] coordenadas = e.TryGetWebMessageAsString().Split(',');

            Latitud = coordenadas[0];
            Longitud = coordenadas[1];

            MessageBox.Show(
                "Latitud: " + Latitud +
                "\nLongitud: " + Longitud
            );
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
