using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using System.Diagnostics;
using Panel = ReaLTaiizor.Controls.Panel;

namespace EpplusSample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            NightPanel Menu = sender as NightPanel;

            if (Menu.Name == "ExcelMenu")
            {
                AppSeparator.Customization = "08aq/9PGqv/Txqr/08aq/w==";
                Menu.Side = NightPanel.PanelSide.Right;
                Pages.SelectedTab = ExcelCreator;
            }
            else
            {
                AppSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
                ExcelMenu.Side = NightPanel.PanelSide.Left;
            }

            if (Menu.Name == "OpenExcelMenu")
            {
                GameSeparator.Customization = "08aq/9PGqv/Txqr/08aq/w==";
                Menu.Side = NightPanel.PanelSide.Right;
                Pages.SelectedTab = ExcelExisting;
            }
            else
            {
                GameSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
                OpenExcelMenu.Side = NightPanel.PanelSide.Left;
            }


            if (Menu.Name == "ViewMenu")
            {
                LibrarySeparator.Customization = "08aq/9PGqv/Txqr/08aq/w==";
                Menu.Side = NightPanel.PanelSide.Right;
                Pages.SelectedTab = ViewPage;
            }
            else
            {
                LibrarySeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
                ViewMenu.Side = NightPanel.PanelSide.Left;
            }

            if (Menu.Name == "HelpMenu")
            {
                HelpSeparator.Customization = "08aq/9PGqv/Txqr/08aq/w==";
                HelpImage.Image = Properties.Resources.HelpBackground;
                Menu.Side = NightPanel.PanelSide.Right;
                Pages.SelectedTab = HelpPage;
            }
            else
            {
                HelpSeparator.Customization = "ICAg/yAgIP8gICD/ICAg/w==";
                HelpMenu.Side = NightPanel.PanelSide.Left;
            }

            Menu.Refresh();
            Menu.Invalidate();
        }

        private void LibraryApp_MouseEnter(object sender, EventArgs e)
        {
            Panel App = sender as Panel;

            App.BackColor = Color.FromArgb(57, 57, 57);
        }

        private void LibraryApp_MouseLeave(object sender, EventArgs e)
        {
            Panel App = sender as Panel;

            App.BackColor = Color.FromArgb(50, 50, 52);
        }

        private void GetHelp_Click(object sender, EventArgs e)
        {
            HelpImage.Image = Properties.Resources.HelpBackground2;

            string Uri = @"https://github.com/ikemyle";

            Process.Start(new ProcessStartInfo
            {
                FileName = Uri,
                UseShellExecute = true
            });

            //try
            //{
            //    Process.Start(Uri);
            //}
            //catch (System.ComponentModel.Win32Exception noBrowser)
            //{
            //    if (noBrowser.ErrorCode == -2147467259)
            //    {
            //        MessageBox.Show(noBrowser.Message);
            //    }
            //}
            //catch (Exception other)
            //{
            //    MessageBox.Show(other.Message);
            //}
        }

        private void PageChanger_Tick(object sender, EventArgs e)
        {
           
        }

        private void excelExporter1_Load(object sender, EventArgs e)
        {

        }
    }
}