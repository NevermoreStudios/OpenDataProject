using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OpenDataProject
{
    public partial class Chart : Form
    {
        List<Skola> Data;
        Vocab vocab;

        public Chart(List<Skola> Data)
        {
            this.Data = Data;
            InitializeComponent();
            RefreshVocab();
        }
        
        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            Text = vocab.chart;
            View.Text = vocab.view;
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            Options1.Items.AddRange(vocab.chartOptions1);
            Options1.SelectedIndex = 0;
            Options2.Items.AddRange(vocab.chartOptions2);
            Options2.SelectedIndex = 0;
        }

        private void View_Click(object sender, EventArgs e)
        {
            Chart1.Series.Clear();
            Chart1.ResetAutoValues();
            int height = Chart1.Height;
            Chart1.Height = 1;
            Chart1.Height = height;
            Dictionary<string, int> chart = new Dictionary<string, int>(); 
            foreach (Skola s in Data)
            {
                switch (Options1.SelectedIndex)
                {
                    case 0:
                        {
                            if (!chart.ContainsKey(s.pbroj))
                            {
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
                                {
                                    chart.Add(s.mesto, 1);
                                }
                                else
                                {
                                    int a;
                                    int.TryParse(s.odeljenja, out a);
                                    chart.Add(s.mesto, a);
                                }
                            }
                            else
                            {
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                                if (Options2.SelectedIndex == 0)
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
                Series series = Chart1.Series.Add(entry.Key);
                series.Points.Add(entry.Value);
            }
        }
    }
}
