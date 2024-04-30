using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist_checker
{
    public partial class FrmCheckList : Form
    {
        private string listName;
        private List<CheckListItem> checkListItems = new List<CheckListItem>();
        public FrmCheckList(string listName)
        {
            InitializeComponent();
            this.listName = listName;
            lblHeader.Text = listName;
            GetCsvData();
            PopulateChecklist();
            lblHeader.Left = (Width) / 2;
        }

        private void PopulateChecklist()
        {
            if (checkListItems != null)
            {
                string position = checkListItems[0].Position;
                string positionCountString = checkListItems[0].Position;
                int positionCount = 0;
                int index = 0;

                foreach (var item in checkListItems)
                {
                    if (item.Position != positionCountString)
                    {
                        positionCount++;
                        positionCountString = item.Position;
                    }
                }

                for (int i = 0; i <= positionCount; i++)
                {
                    if (index < checkListItems.Count())
                    {
                        Panel panel = new Panel();
                        //panel.AutoSize = true;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.BackColor = Color.LightGray;
                        panel.Height = 825;

                        Label label = new Label();
                        position = checkListItems[index].Position;
                        label.AutoSize = true;
                        label.Text = position;
                        label.Font = new Font(label.Font.FontFamily, 12);
                        label.Padding = new Padding(5);

                        panel.Controls.Add(label);

                        //Add checkboxes to panel
                        int cboBottom = label.Bottom;
                        int cboLeft = 0;
                        int panelWidthCount = 1;
                        int maxCboWidth = 0;

                        while (checkListItems[index].Position == position)
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = checkListItems[index].Text;
                            checkBox.Checked = checkListItems[index].IsChecked;
                            checkBox.AutoSize = true;
                            checkBox.Padding = new Padding(5);

                            if (checkBox.Width > maxCboWidth)
                            {
                                maxCboWidth = checkBox.Width;
                            }

                            if (cboBottom > 800)
                            {
                                cboBottom = label.Bottom;
                                cboLeft += checkBox.Width;
                                panelWidthCount++;
                            }
                            checkBox.Location = new Point(cboLeft, cboBottom);
                            cboBottom = checkBox.Bottom;

                            // Add event handler for check state changed
                            int currentIndex_local = index;
                            checkBox.CheckedChanged += (sender, e) =>
                            {
                                // Update checklist item state
                                checkListItems[currentIndex_local].IsChecked = checkBox.Checked;
                            };
                            panel.Width = panelWidthCount * maxCboWidth;
                            panel.Width = Math.Max(panel.Width, label.Width);
                            panel.Controls.Add(checkBox);
                            index++;
                            if (index == checkListItems.Count()) { break; }

                        }

                        //add panel to flowLayout
                        flowLayoutPanelChecklist.Controls.Add(panel);
                    }


                }

                flowLayoutPanelChecklist.AutoSize = true;
                flowLayoutPanelChecklist.FlowDirection = FlowDirection.LeftToRight;
            }
        }

        private void PopulateChecklistOld()
        {
            string position = checkListItems[0].Position;

            Panel panel1 = new Panel();
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.AutoSize = true;

            Label labelPos1 = new Label();
            labelPos1.Text = position;
            labelPos1.Font = new Font(labelPos1.Font.FontFamily, 12);
            panel1.Controls.Add(labelPos1);

            CheckBox checkBox1 = new CheckBox();
            checkBox1.Text = checkListItems[0].Text;
            checkBox1.Checked = checkListItems[0].IsChecked;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, labelPos1.Height);
            panel1.Controls.Add(checkBox1);

            flowLayoutPanelChecklist.Controls.Add(panel1);
            MessageBox.Show("label posistion: " + labelPos1.Location + " checkbox position: " + checkBox1.Location);

            foreach (var item in checkListItems)
            {
                if (item.Position != position)
                {
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    Label label = new Label();
                    position = item.Position;
                    label.Text = position;
                    label.Font = new Font(label.Font.FontFamily, 12);

                    flowLayoutPanelChecklist.Controls.Add(label);
                }
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.Text;
                checkBox.Checked = item.IsChecked;
                checkBox.AutoSize = true;

                // Add event handler for check state changed
                checkBox.CheckedChanged += (sender, e) =>
                {
                    // Update checklist item state
                    item.IsChecked = checkBox.Checked;
                };

                flowLayoutPanelChecklist.Controls.Add(checkBox);
            }
        }

        private void GetCsvData()
        {
            string path;

            path = listName + ".csv";

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist.");
            }
            else
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    CheckListItem item = new CheckListItem(values[0], values[1]);
                    checkListItems.Add(item);
                }
            }
        }

        private void SendToDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sign;
            sign = txtSign.Text;
            MessageBox.Show("Takk " +sign+"\nDin sjekkliste har blitt lagret");
        }
    }
}
