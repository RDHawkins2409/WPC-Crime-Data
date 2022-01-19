using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WPC_Crime_Data
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ValidateNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar != '\b' && ((sender as TextBox).Text.IndexOf('-') > ((sender as TextBox).SelectionStart -1)))
            {
                e.Handled=true;
            }

            if (e.KeyChar == '-' && (((sender as TextBox).Text.IndexOf('-') > (sender as TextBox).SelectionStart) || ((sender as TextBox).SelectionStart != 0)))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtResults.Text = getData(txtLatitude.Text, txtLongitude.Text, dtpDate.Value);
        }

        public string getData(string lat, string lng, DateTime date)
        {
            string urlBase = String.Format("https://data.police.uk/api/crimes-street/all-crime?lat={0}&lng={1}&date={2}-{3:D2}", lat, lng, date.Year, date.Month);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<Crime> deserialised = JsonConvert.DeserializeObject<List<Crime>>(content);
            List<Tuple<string, int>> summary = new List<Tuple<string, int>>();
            if (deserialised.Count > 0)
            {
                foreach (Crime c in deserialised)
                {
                    int index = summary.FindIndex(x => x.Item1 == c.Category);
                    if (index > -1)
                    {
                        summary[index] = new Tuple<string, int>(summary[index].Item1, summary[index].Item2 + 1);
                    }
                    else
                    {
                        summary.Add(new Tuple<string, int>(c.Category, 1));
                    }
                }
                string output = "";
                foreach (Tuple<string, int> item in summary.OrderBy(x => x.Item1))
                {
                    output = output + item.Item1 + " - " + item.Item2 + Environment.NewLine;
                }
                return output;
            }
            else
            {
                return "No Crime Data Found";
            }
        }
    }
}