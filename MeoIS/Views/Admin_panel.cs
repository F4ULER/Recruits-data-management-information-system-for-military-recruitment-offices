﻿using System;
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

            tableLayoutPanelFilterSearch.Visible = false;
            tabControlMenuFunctions.Visible = false;
            tabControlExportAndStatistics.Visible = false;
            panelRegOfSummons.Visible = false;
        }

        // иконка поиска
        private void picSearch_Click_1(object sender, EventArgs e)
        {
            Advanced_search search = new Advanced_search();
            DataBaseConnect dataBase = new DataBaseConnect();
            DataTable table = new DataTable();

            if (tBSearch.Text != "")
            {
                tableLayoutPanelFilterSearch.Visible = false;



                string[] fullName = tBSearch.Text.Split(new char[] { ' ' });
                table = search.searchFullName(fullName[0], " ", " ");




                if (rBSearchDocNum.Checked == true)
                {
                    table = search.searchDocumentNumber(tBSearch.Text);
                }
                else if (rBSearchName.Checked == true)
                {
                    string[] fullName1 = tBSearch.Text.Split(new char[] { ' ' });

                    switch (fullName.Length)
                    {
                        case 1:
                            table = search.searchFullName(fullName[0], " ", " ");
                            break;
                        case 2:
                            table = search.searchFullName(fullName[0], fullName[1], " ");
                            break;
                        case 3:
                            table = search.searchFullName(fullName[0], fullName[1], fullName[2]);
                            break;
                    }
                }
                else if (rBSearchDistrict.Checked == true)
                {
                    table = search.searchDistrict(tBSearch.Text);
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
                else if (rBEducation.Checked == true)
                {
                    table = search.searchEducation(tBSearch.Text);
                }

                if (table.Rows.Count > 0)
                {

                    dataGV.DataSource = table;
                    dataGV.Visible = true;
                }
                else
                {
                    MessageBox.Show("Не найдено ни одной записи");
                    pictureClose.Visible = false;
                }
            }
            else
            {
                table = dataBase.sending_command_with_output_to_table("SELECT * FROM `users` WHERE 1");
                dataGV.DataSource = table;
                dataGV.Visible = true;
                pictureClose.Visible = true;
            }

            if(dataGV.Visible == true || panelNewAdmin.Visible == true) { pictureClose.Visible = true; }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text != "")
            {
                rBSearchDocNum.Checked = true;
                tableLayoutPanelFilterSearch.Visible = true;
            }
            else tableLayoutPanelFilterSearch.Visible = false;
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

        // добавление пользователя
        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            if (tBDocNumber.Text != "" &&
            tBPass.Text != "" &&
            tBLastName.Text != "" &&
            tBNameUser.Text != "" &&
            tBPatronymic.Text != "" &&
            tBAge.Text != "" &&
            cBCategory.Text != "" &&
            cBDistrict.Text != "" &&
            tBPhone.Text != "" &&
            tBEmail.Text != "")
            {
                User_data user_Data = new User_data();
                string gender = "";
                if (rBM.Checked == true) { gender = "M"; } else { gender = "Ж"; };
                if(user_Data.addUser(tBDocNumber.Text, tBPass.Text, tBLastName.Text, tBNameUser.Text, tBPatronymic.Text, tBAge.Text, tBAddress.Text, cBCategory.Text, gender, cBDistrict.Text, tBPhone.Text, tBEmail.Text))
                {

                    MessageBox.Show("Польователь успешно добавлен!");
                }

                tBDocNumber.Text = "";
                tBPass.Text = "";
                tBLastName.Text = "";
                tBNameUser.Text = "";
                tBPatronymic.Text = "";
                tBAge.Text = "";
                cBCategory.Text = "";
                cBDistrict.Text = "";
                tBPhone.Text = "";
                tBEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        // поиск пользоваетля для удаления записи о нем (иконка стрелки)
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

        // удаление пользователя
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (tBDocNumDelete.Text != "")
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
            else
            {
                MessageBox.Show("Введите номер документа.");
            }
        }

        // поле ввода номера документа (изменение пользователя)
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

        // изменение записи о пользователе
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (tBChangeUser.Text != "" && tBChange.Text != "")
            {
                User_data user_Data = new User_data();
                if (rBDocNumChangeUser.Checked == true)
                {
                    user_Data.change_document_number(tBChangeUser.Text, tBChange.Text);
                }
                else if (rBNameChangeUser.Checked == true)
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
            } else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        // выдача прав администратора
        private void buttonNewAdmin_Click(object sender, EventArgs e)
        {
            if (tBDocNumNewAdmin.Text != "")
            {
                LogIn logIn = new LogIn();
                logIn.give_superrights(tBDocNumNewAdmin.Text);
                panelNewAdmin.Visible = false;
                groupBoxServices.Visible = true;
                tBDocNumNewAdmin.Text = "";
                pictureClose.Visible = false;
            } else
            {
                MessageBox.Show("Введите номер документа пользователя, которому хотите выдать права администратора.");
            }
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

        //добавление литературы
        private void buttonAddLit_Click(object sender, EventArgs e)
        {
            if (tBTitle.Text != "" && tBAuthor.Text != "" && tBSummary.Text != "" && tBKeywords.Text != "" && tBLink.Text != "" && tBDateAdded.Text != "")
            {
                Literature_guide literature = new Literature_guide();
                literature.addLiterature(tBTitle.Text, tBAuthor.Text, tBSummary.Text, tBKeywords.Text, tBLink.Text, tBDateAdded.Text);
                tabControlLit.Visible = false;
            } else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        // поиск литературы для удаления записи о ней (иконка стрелки)
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

        //удаление литературы
        private void buttonDeleteLit_Click(object sender, EventArgs e)
        {
            if (tBDeleteLit.Text != "")
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
            } else
            {
                MessageBox.Show("Введите название");
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            tabControlLit.Visible = false;
            pictureClose.Visible = false;
            tabControlMenuFunctions.Visible = false;
            panelNewAdmin.Visible = false;
            tabControlExportAndStatistics.Visible = false;
            tBExport.Text = "";
            dataGV.Visible = false;
            groupBoxServices.Visible = true;
            tBSearch.Text = "";
            panelRegOfSummons.Visible = false;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Transfer.Name = "";
            labelWelcome.Text = "";
            this.Hide();
        }

        //отображение меню статистики и экспорта(иконка экспорта)
        private void pictureExport_Click(object sender, EventArgs e)
        {
            tabControlExportAndStatistics.Visible = true;
            groupBoxServices.Visible = false;
            pictureClose.Visible = true;
        }

        //кнопка показать статисику в вкладке Статистика
        private void buttonShowStat_Click(object sender, EventArgs e)
        {
            Advanced_search search = new Advanced_search();
            Collect_statistics statistics = new Collect_statistics();

            if (rBStatGender.Checked == true)
            {
                statistics.statistics_By_Gender(search.searchAllUsersToList(), true); ;
            }
            else if (rBStatDistrict.Checked == true)
            {
                statistics.statistics_By_District(search.searchAllUsersToList(), true);
            }
            else if (rBStatAge.Checked == true)
            {
                statistics.statistics_By_Age(search.searchAllUsersToList(), true);
            }
            else if (rBStatCategory.Checked == true)
            {
                statistics.statistics_By_Category(search.searchAllUsersToList(), true);
            }
            else { MessageBox.Show("Выберите параметр для отображения статистики."); }
        }

        //кнопка Экспортировать в вкладке Экспорт
        private void buttonExport_Click(object sender, EventArgs e)
        {
            Advanced_search search = new Advanced_search();
            Collect_statistics statistics = new Collect_statistics();

            if (rBExportDistrict.Checked == true)
            {
                statistics.export_to_Excel(search.searchDistrict(tBExport.Text), "Данные призывников в районе " + tBExport.Text);
            }
            else if (rBExportCategory.Checked == true)
            {
                statistics.export_to_Excel(search.searchCategory(tBExport.Text), "Данные призывников с категорией " + tBExport.Text);
            }
            else if (rBExpTXTDistrict.Checked == true)
            {
                statistics.statistics_By_District(search.searchAllUsersToList(), false);
            }
            else if (rBExpTXTAge.Checked == true)
            {
                statistics.statistics_By_Age(search.searchAllUsersToList(), false);
            }
            else if (rBExpTXTGender.Checked == true)
            {
                statistics.statistics_By_Gender(search.searchAllUsersToList(), false);
            }
            else if (rBExpTXTCategory.Checked == true)
            {
                statistics.statistics_By_Category(search.searchAllUsersToList(), false);
            }
            else if (rBExportAll.Checked == true)
            {
                statistics.export_to_Excel(search.searchAllUsersToTable(), "Вся таблица пользователей");
            }
            tBExport.Text = "";
        }

        private void pictureRegisterOfSummons_Click(object sender, EventArgs e)
        {
            panelRegOfSummons.Visible = true;
            groupBoxServices.Visible = false;
            pictureClose.Visible = true;
            buttonRegOfSummonsSaveEdit.Enabled = false;
        }

        private void buttonRegOfSummonsSave_Click(object sender, EventArgs e)
        {
            Register_of_summons_to_enlistment__office RegOfSummons = new Register_of_summons_to_enlistment__office();

            RegOfSummons.addSummons(tBRegOfSummonsDocNumber.Text, tBRegOfSummonsSeries.Text, tBRegOfSummonsNumber.Text, tBRegOfSummonsDateOfVisit.Text, "Активно");
            tBRegOfSummonsDocNumber.Text = "";
            tBRegOfSummonsSeries.Text = "";
            tBRegOfSummonsNumber.Text = "";
            tBRegOfSummonsDateOfVisit.Text = "";
        }

        private void buttonRegOfSummonsEditSearch_Click(object sender, EventArgs e)
        {
            Advanced_search advanced_Search = new Advanced_search();
            DataTable tableSummons;
            tableSummons = advanced_Search.searchSummonBySeriesAndNumberToTable(tBRegOfSummonsEditSeries.Text, tBRegOfSummonsEditNumber.Text);

            if (tableSummons.Rows.Count > 0)
            {
                buttonRegOfSummonsSaveEdit.Enabled = true;
                switch (tableSummons.Rows[0][5].ToString())
                {
                    case "Активно":
                        cBRegOfSummonsStatus.SelectedIndex = 0;
                        break;
                    case "Просрочено":
                        cBRegOfSummonsStatus.SelectedIndex = 1;
                        break;
                    case "Закрыто":
                        cBRegOfSummonsStatus.SelectedIndex = 2;
                        break;
                }
            }else { MessageBox.Show("Такой повестки не существует"); buttonRegOfSummonsSaveEdit.Enabled = false; }
        }

        private void buttonRegOfSummonsSaveEdit_Click(object sender, EventArgs e)
        {
            Register_of_summons_to_enlistment__office RegOfSummons = new Register_of_summons_to_enlistment__office();
            RegOfSummons.editStatusSummons(tBRegOfSummonsEditSeries.Text, tBRegOfSummonsEditNumber.Text, cBRegOfSummonsStatus.Text);
            buttonRegOfSummonsSaveEdit.Enabled = false;
            tBRegOfSummonsEditSeries.Text = "";
            tBRegOfSummonsEditNumber.Text = "";
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {

        }
    }
}
