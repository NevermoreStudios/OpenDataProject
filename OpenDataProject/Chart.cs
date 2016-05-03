using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OpenDataProject
{
    public partial class Chart : Form
    {
        List<Skola> Data;
        public Chart(List<Skola> Data)
        {
            this.Data = Data;
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Broj skola");
            comboBox2.Items.Add("Broj odeljenja");
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("Postanski broj");
            comboBox1.Items.Add("Mesto");
            comboBox1.Items.Add("Opstina");
            comboBox1.Items.Add("Okrug");
            comboBox1.Items.Add("Skolska uprava");
            comboBox1.Items.Add("Tip skole");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Dictionary<string, int> chart = new Dictionary<string, int>(); 
            foreach (Skola s in Data)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            if (!chart.ContainsKey(s.pbroj))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.pbroj, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.pbroj, a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.pbroj] +=1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart[s.pbroj] += a;
                                }
                            }
                            break;
                        }
                    case 1:
                        {
                            if (!chart.ContainsKey(s.mesto))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.mesto, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.mesto,a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.mesto] += 1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart[s.mesto] += a;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            if (!chart.ContainsKey(s.opstina))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.opstina, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.opstina, a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.opstina] += 1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart[s.opstina] += a;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            if (!chart.ContainsKey(s.okrug))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.okrug, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.okrug, a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.okrug] += 1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart[s.okrug] += a;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            if (!chart.ContainsKey(s.suprava))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.suprava, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.suprava, a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.suprava] += 1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart[s.suprava] += a;
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            if (!chart.ContainsKey(s.vrsta))
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart.Add(s.vrsta, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja,out a);
                                    chart.Add(s.vrsta, a);
                                }
                            }
                            else
                            {
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    chart[s.vrsta] += 1;
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja,out a);
                                    chart[s.vrsta] += a;
                                }
                            }
                            break;
                        }
                }
            }

            foreach (KeyValuePair<string, int> entry in chart)
            {
                Series series = this.chart1.Series.Add(entry.Key);
                series.Points.Add(entry.Value);
            }


        }
    }
}
