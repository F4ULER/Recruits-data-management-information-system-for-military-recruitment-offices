using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();

            labelWelcome.Text = "Добрый день, " + Transfer.Name;
            dataGV.Visible = false;

            tableLayoutPanelFilter.Visible = false;
            tabControlMenuFunctions.Visible = false;
        }

        private void picSearch_Click_1(object sender, EventArgs e)
        {
            pictureClose.Visible = true;
            Advanced_search search = new Advanced_search();
            DataTable table = new DataTable();

            if (tBSearch.Text != "")
            {
                tableLayoutPanelFilter.Visible = false;
                
                if (rBSearchDocNum.Checked == true)
                {
                    table = search.searchDocumentNumber(tBSearch.Text);
                }
                else if (rBSearchName.Checked == true)
                {
                    string[] fullName = tBSearch.Text.Split(new char[] { ' ' });

                    switch (fullName.Length)
                    {
                        case 1:
                            table = search.searchFullName(fullName[0], "", "");
                            break;
                        case 2:
                            table = search.searchFullName(fullName[0], fullName[1], "");
                            break;
                        case 3:
                            table = search.searchFullName(fullName[0], fullName[1], fullName[2]);
                            break;
                    }
                }
                else if (rBSearchCity.Checked == true)
                {
                    table = search.searchMilitaryRegistrationAndEnlistmentOffice(tBSearch.Text);
                }
                else if (rBSearchPhone.Checked == true)
                {
                    table = search.searchPhoneNumber(tBSearch.Text);
                }
                else if (rBSearchMedData.Checked == true)
                {
                    table = search.searchMedicalData(tBSearch.Text);
                }
                else if (rBSearchLit.Checked == true)
                {
                    table = search.search_literature(tBSearch.Text);
                }

                if (table.Rows.Count > 0)
                {

                    dataGV.DataSource = table;
                    dataGV.Visible = true;
                }
                else
                {
                    MessageBox.Show("Не найдено ни одной записи");
                }
            }
            else
            {
                search.sending_command("SELECT * FROM `users` WHERE 1");
            }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text != "")
            {
                rBSearchDocNum.Checked = true;
                tableLayoutPanelFilter.Visible = true;
            }
            else tableLayoutPanelFilter.Visible = false;
        }

        private void Admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрытие всего приложения
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void labelEditingUserDatabase_Click(object sender, EventArgs e)
        {
            tabControlMenuFunctions.Visible = true;
            groupBoxServices.Visible = false;
            pictureClose.Visible = true;
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            User_data user_Data = new User_data();
            string gender = "";
            if(rBM.Checked == true) { gender = "M"; } else { gender = "Ж"; };
            user_Data.addUser(tBDocNumber.Text, tBPass.Text, tBLastName.Text, tBNameUser.Text, tBPatronymic.Text, tBAge.Text, tBCategory.Text, gender,tBCity.Text, tBPhone.Text, tBEmail.Text);

            tBDocNumber.Text = "";
            tBPass.Text = "";
            tBLastName.Text = "";
            tBNameUser.Text = "";
            tBPatronymic.Text = "";
            tBAge.Text = "";
            tBCategory.Text = "";
            tBCity.Text = "";
            tBPhone.Text = "";
            tBEmail.Text = "";
        }

        private void pictureArrowDel_Click(object sender, EventArgs e)
        {
            Advanced_search search = new Advanced_search();
            DataTable table = new DataTable();
            table = search.searchDocumentNumber(tBDocNumDelete.Text);

            if (table.Rows.Count > 0)
            {
                dataGridViewDelete.DataSource = table;
                dataGridViewDelete.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            User_data user_ = new User_data();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данного пользователя?", "Удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                user_.deleteUser(tBDocNumDelete.Text);

                tBDocNumDelete.Text = "";
                dataGridViewDelete.Visible = false;
            }
        }

        private void tBChangeUser_TextChanged(object sender, EventArgs e)
        {
            if (tBChangeUser.Text != "")
            {
                rBDocNumChangeUser.Checked = true;
                tableLayoutPanelChangeUser.Visible = true;
                buttonChange.Visible = true;
                label16.Visible = true;
                tBChange.Visible = true;
            }
            else
            {
                tableLayoutPanelChangeUser.Visible = false;
                buttonChange.Visible = false;
                label16.Visible = false;
                tBChange.Visible = false;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            User_data user_Data = new User_data();
            if(rBDocNumChangeUser.Checked == true)
            {
                user_Data.change_document_number(tBChangeUser.Text, tBChange.Text);
            } else if (rBNameChangeUser.Checked == true)
            {
                user_Data.change_full_name(tBChangeUser.Text, tBChange.Text);
            }
            else if (rBPhoneChangeUser.Checked == true)
            {
                user_Data.change_phone_number(tBChangeUser.Text, tBChange.Text);
            }
            else if (rBEmailChangeUser.Checked == true)
            {
                user_Data.change_email(tBChangeUser.Text, tBChange.Text);
            }
            else if (rBCategoryChangeUser.Checked == true)
            {
                user_Data.change_category_of_suitability_for_military_service(tBChangeUser.Text, tBChange.Text);
            }
        }

        private void buttonNewAdmin_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.give_superrights(tBDocNumNewAdmin.Text);
            panelNewAdmin.Visible = false;
            groupBoxServices.Visible = true;
            tBDocNumNewAdmin.Text = "";
        }

        private void labelAppointmentOfNewAdministrator_Click(object sender, EventArgs e)
        {
            panelNewAdmin.Visible = true;
            groupBoxServices.Visible = false;
            pictureClose.Visible = true;
        }

        private void labelUpdatingTheReferenceBook_Click(object sender, EventArgs e)
        {
            tabControlLit.Visible = true;
            groupBoxServices.Visible = false;
            pictureClose.Visible = true;
        }

        private void buttonAddLit_Click(object sender, EventArgs e)
        {
            Literature_guide literature = new Literature_guide();
            literature.addLiterature(tBTitle.Text, tBAuthor.Text,tBSummary.Text, tBKeywords.Text, tBLink.Text, tBDateAdded.Text);
            tabControlLit.Visible = false;
        }

        private void pictureArrowDeleteLit_Click(object sender, EventArgs e)
        {
            Advanced_search search = new Advanced_search();
            DataTable table = new DataTable();
            table = search.search_literature(tBDeleteLit.Text);

            if (table.Rows.Count > 0)
            {
                dataGridViewDeleteLit.DataSource = table;
                dataGridViewDeleteLit.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
            }
        }

        private void buttonDeleteLit_Click(object sender, EventArgs e)
        {
            Literature_guide literature_Guide = new Literature_guide();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                literature_Guide.deleteLiterature(tBDeleteLit.Text);

                tBDeleteLit.Text = "";
                dataGridViewDeleteLit.Visible = false;
            }
            tabControlLit.Visible = false;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            tabControlLit.Visible = false;
            pictureClose.Visible = false;
            tabControlMenuFunctions.Visible = false;
            panelNewAdmin.Visible = false;
            dataGV.Visible = false;
            groupBoxServices.Visible = true;
        }
    }
}
