﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CRM_BAL;
using CRM_DAL;


namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for CRM_MainForm.xaml
    /// </summary>
    /// 
      
    public partial class CRM_MainForm : Window
    {


        string caption = "Green Future Glob";
        int cid;
      
        public CRM_MainForm()
        {
            InitializeComponent();
           
          DateTime  s =Convert .ToDateTime ( System.DateTime.Now.ToShortDateString());
            //Load_Domain();
            checkedStuff = new List<string>();
            PREPROCUREMENTid();
            
           
        }
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        BAL_AddProduct baddprd = new BAL_AddProduct();
        DAL_AddProduct dalprd = new DAL_AddProduct();
        string maincked;
        string  bpg;
        int fetcdoc;
        List<string> checkedStuff;


        BAL_Pre_Procurement bpreproc = new BAL_Pre_Procurement();
        DAL_Pre_Procurement dpreproc = new DAL_Pre_Procurement();

        BAL_Followup balfollow = new BAL_Followup();
        DAL_Followup dalfollow = new DAL_Followup();


        public void PREPROCUREMENTid()
        {

            int id1 = 0;
            // SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select (COUNT(ID)) from Pre_Procurement", con);
            id1 = Convert.ToInt32(cmd.ExecuteScalar());
            id1 = id1 + 1;
            lblPro_no.Content  = "# Pre_Proc/" + id1.ToString();
            con.Close();


        }
        public void FolloupID_fetch()
        {

            int id1 = 0;
            // SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select (COUNT(ID)) from tlb_FollowUp", con);
            id1 = Convert.ToInt32(cmd.ExecuteScalar());
            id1 = id1 + 1;
            lblwalkin .Content = "# Followup/" + id1.ToString();
            con.Close();


        }
        private void btnadminlogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AdminLogin al = new AdminLogin();
            al.Show();
        }

        private void btnmainexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Main_Login mn = new Main_Login();
        }

        private void btnP_Exit_Click(object sender, RoutedEventArgs e)
        {
            clearAllADDProducts();
            grd_U_AddProducts.Visibility = Visibility.Hidden;
            

        }

        private void smaddproduct_Click(object sender, RoutedEventArgs e)
        {

            grd_U_AddProducts. Visibility = Visibility;
        }

        private void btnP_AddDomain_Click(object sender, RoutedEventArgs e)
        {
            grd_Domain.Visibility = Visibility;
        }

        private void btndomainexit_Click(object sender, RoutedEventArgs e)
        {
            grd_Domain.Visibility = Visibility.Hidden ;
        }

        private void btnProduct_Exit_Click(object sender, RoutedEventArgs e)
        {
            grd_Product.Visibility = Visibility.Hidden; 
        }

        private void btnP_AddProduct_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnBrandExit_Click(object sender, RoutedEventArgs e)
        {
            grd_Brand.Visibility = Visibility.Hidden; 
        }

        private void btnP_AddBrand_Click(object sender, RoutedEventArgs e)
        {
           
            grd_Brand.Visibility = Visibility;
            Load_DomainB();

        }

        private void btnPCategoryExit_Click(object sender, RoutedEventArgs e)
        {
            grd_ProductCategory.Visibility = Visibility.Hidden; 
            
        }

        private void btnP_AddPCategory_Click(object sender, RoutedEventArgs e)
        {
            grd_ProductCategory.Visibility = Visibility;
            Load_PCDomain();
        }

        private void btnmodelnoexie_Click(object sender, RoutedEventArgs e)
        {
            grd_ModelNo.Visibility = Visibility.Hidden;  
        }

        private void btnP_AddModelNo_Click(object sender, RoutedEventArgs e)
        {
            grd_ModelNo.Visibility = Visibility;
            Load_MDomain();
        }

        private void btnColorExit_Click(object sender, RoutedEventArgs e)
        {
            grd_Color.Visibility = Visibility.Hidden; 
        }

      
        private void btnP_AddColor1_Click(object sender, RoutedEventArgs e)
        {
            grd_Color.Visibility = Visibility;
        }

        private void btnP_AddColor1_Click_1(object sender, RoutedEventArgs e)
        {
            grd_Color.Visibility = Visibility;
            Load_CDomain();
        }

        private void btndomainsave_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    string strpan, stradhar, strpass, straddress, strseventw, strfrm16, strdelerlic, strnoidpf, strnodoc, strcmpid;
                    baddprd.Flag = 1;
                    baddprd.Domain_Name = txtdomain.Text;
                    if(chkpancard.IsChecked ==true )
                    {
                        strpan = "Yes";
                    }
                    else
                    {
                        strpan = "No";
                    }
                    if(chkadharcard.IsChecked == true)
                    {
                        stradhar = "Yes";
                    }
                    else
                    {
                        stradhar = "No";
                    }
                    if(chkPassport.IsChecked == true)
                    {
                        strpass = "Yes";
                    }
                    else
                    {
                        strpass = "No";
                    }
                    if(chkaddress.IsChecked == true)
                    {
                        straddress = "Yes";
                    }
                    else
                    {
                        straddress = "No";
                    }
                    if(chkseventwelve.IsChecked == true)
                    {
                        strseventw = "Yes";
                    }
                    else
                    {
                        strseventw = "No";
                    }
                    if(chkform16.IsChecked == true)
                    {
                        strfrm16 = "Yes";
                    }
                    else
                    {
                        strfrm16 = "No";
                    }
                    if(chkdealerlisence.IsChecked == true)
                    {
                        strdelerlic = "Yes";
                    }
                    else
                    {
                        strdelerlic = "No";
                    }
                    if(chkotherid.IsChecked == true)
                    {
                        strnoidpf  = "Yes";
                    }
                    else
                    {
                        strnoidpf = "No";
                    }
                    if (chknodocument .IsChecked ==true )
                    {
                        strnodoc = "Yes";
                    }
                    else { strnodoc = "No"; }
                    if(chkcidproof.IsChecked == true)
                    {
                        strcmpid = "Yes";
                    }
                    else
                    {
                        strcmpid = "No";
                    }
                    baddprd.PAN_Card = strpan;
                    baddprd.Adhar_Card = stradhar;
                    baddprd.Passport = strpass;
                    baddprd.Address_Proof = straddress;
                    baddprd.Seven_Twevel = strseventw;
                    baddprd.Form_16 = strfrm16;
                    baddprd.Dealer_Lisence = strdelerlic;
                    baddprd.Other_ID_Proof = strnoidpf;
                    baddprd.No_Documents = strnodoc;
                    baddprd.Cmp_ID_Proof = strcmpid;
                    baddprd.S_Status = "Active";

                    baddprd.C_Date =Convert .ToDateTime ( System.DateTime.Now.ToShortDateString());
                    dalprd.AddDomain_Insert_Update_Delete(baddprd);
                    MessageBox.Show ("Data Save Successfully");
                    txtdomain.Text = "";
                    Load_Domain();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            
        }
        //string STRTODAYDATE = System.DateTime.Now.ToShortDateString();
        //string time = System.DateTime.Now.ToShortTimeString();
        //string[] STRVAL = STRTODAYDATE.Split('-');
        //string STR_DATE1 = STRVAL[0];
        //string STR_MONTH = STRVAL[1];
        //string STR_YEAR = STRVAL[2];
        //string DATE = STR_DATE1 + "-" + STR_MONTH + "-" + STR_YEAR;
        ////txtdate.Text = DATE;
        ////txttime.Text = time;

        //baddprd.C_Date =Convert .ToDateTime( DATE);
        public void Load_Domain()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_domain.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_domain.ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_domain.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
          
        }
        public void Load_DomainP()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmb_DomainProduct.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmb_DomainProduct .ItemsSource = ds.Tables[0].DefaultView;
                    cmb_DomainProduct.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Fetch_Product()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_ID,Product_Name from tlb_Products where  Domain_ID='" + cmbP_domain .SelectedValue.GetHashCode() + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_Product.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_Product .ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_Product.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Load_BrandProduct()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_ID, Product_Name from tlb_Products where Domain_ID ='" + cmbDomainBrand.SelectedValue.GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbProductBrand.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbProductBrand .ItemsSource = ds.Tables[0].DefaultView;
                    cmbProductBrand.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Load_DomainB()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbDomainBrand.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbDomainBrand .ItemsSource = ds.Tables[0].DefaultView;
                    cmbDomainBrand.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void fetch_Brand()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Brand_Name from tlb_Brand where Product_ID='"+cmbP_Product .SelectedValue .GetHashCode ()+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_Brand.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_Brand .ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_Brand.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        private void grdMainFormGrid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void grd_U_AddProducts_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Domain();
            //Load_DomainP();
            //fetch_Brand();
            //Fetch_PC();
            //fetch_Model();
            //fetch_Color();
        }

        private void btnProductSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                baddprd.Flag = 1;
                baddprd.Domain_ID =Convert .ToInt32 ( cmb_DomainProduct.SelectedValue.GetHashCode());
                baddprd.Product_Name = txtProductName.Text;
                baddprd.S_Status = "Active";

              
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd.AddProducts_Insert_Update_Delete(baddprd);
                MessageBox.Show("Data Save Successfully");
                txtProductName.Text = "";
                Load_DomainP();
                //Fetch_Product();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnadminl_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adl = new AdminLogin();
            adl.Show();
        }

        private void btnP_AddProduct_Click_1(object sender, RoutedEventArgs e)
        {
            grd_Product.Visibility = Visibility;
            Load_DomainP();
        }

        private void btnBrandSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                baddprd.Flag = 1;
                baddprd.Product_ID  = Convert.ToInt32(cmbProductBrand .SelectedValue.GetHashCode());
                baddprd.Brand_Name  = txtBrand.Text;
                baddprd.S_Status = "Active";
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd.AddBrand_Insert_Update_Delete (baddprd);
                MessageBox.Show("Data Save Successfully");
                txtBrand .Text = "";
                cmbProductBrand.SelectedValue = null;
                Load_Domain();
               // fetch_Brand();
               // Load_DomainB();
               // Load_BrandProduct();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void cmbDomainBrand_DropDownClosed(object sender, EventArgs e)
        {
           // Load_BrandProduct();
           // Load_DomainB();
        }

        private void btnPCategorySave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                baddprd.Flag = 1;
                baddprd.Brand_ID = Convert.ToInt32(cmbBrandPCategory .SelectedValue.GetHashCode());
                baddprd.Product_Category  = txtPCategoy .Text;
                baddprd.S_Status = "Active";
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd.AddP_Category_Insert_Update_Delete (baddprd);
                MessageBox.Show("Data Save Successfully");
                txtPCategoy.Text = "";
                cmbBrandPCategory.SelectedValue = null;
                cmbProductPCategoryy.SelectedValue = null;
                cmbDomainPCategory.SelectedValue = null;
                Load_Domain();
              //  Load_PCDomain();
               // Fetch_PC();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Load_PCDomain()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbDomainPCategory.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbDomainPCategory .ItemsSource = ds.Tables[0].DefaultView;
                    cmbDomainPCategory.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Load_PCProduct()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Domain_ID, Product_Name from tlb_Products where Domain_ID='" + cmbDomainPCategory.SelectedValue.GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbProductPCategoryy .SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbProductPCategoryy.ItemsSource = ds.Tables[0].DefaultView;
                    cmbProductPCategoryy.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_PCBrand()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Product_ID, Brand_Name from tlb_Brand where Product_ID='" + cmbProductPCategoryy.SelectedValue.GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbBrandPCategory .SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbBrandPCategory.ItemsSource = ds.Tables[0].DefaultView;
                    cmbBrandPCategory.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Fetch_PC()
        {

            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT  ID,Product_Category from tlb_P_Category where Brand_ID='"+cmbP_Brand .SelectedValue .GetHashCode ()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_PCategory.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_PCategory .ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_PCategory.DisplayMemberPath = ds.Tables[0].Columns["Product_Category"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void cmbDomainPCategory_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void cmbProductPCategoryy_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void btnModelNoSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                baddprd.Flag = 1;
                baddprd.P_Category   = Convert.ToInt32(cmbPCategoryModelno.SelectedValue.GetHashCode());
                baddprd.Model_No  = txtmodelno.Text;
                baddprd.S_Status = "Active";
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd. AddModel_Insert_Update_Delete(baddprd);
                MessageBox.Show("Data Save Successfully");
                txtmodelno.Text = "";
                cmbDomainModelno.SelectedValue = null;
                cmbProductModelno.SelectedValue = null;
                cmbBrandModelno.SelectedValue = null;
                cmbPCategoryModelno.SelectedValue = null;
                Load_Domain();
               
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Load_MDomain()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbDomainModelno.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbDomainModelno .ItemsSource = ds.Tables[0].DefaultView;
                    cmbDomainModelno.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_MProduct()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Domain_ID, Product_Name from tlb_Products where Domain_ID='" + cmbDomainModelno.SelectedValue .GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbProductModelno.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbProductModelno .ItemsSource = ds.Tables[0].DefaultView;
                    cmbProductModelno.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_MBrand()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Product_ID,Brand_Name from tlb_Brand where Product_ID='" + cmbProductModelno.SelectedValue.GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbBrandModelno.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbBrandModelno .ItemsSource = ds.Tables[0].DefaultView;
                    cmbBrandModelno.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_MPC()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Brand_ID, Product_Category from tlb_P_Category where Brand_ID='" + cmbBrandModelno.SelectedValue .GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPCategoryModelno.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbPCategoryModelno .ItemsSource = ds.Tables[0].DefaultView;
                    cmbPCategoryModelno.DisplayMemberPath = ds.Tables[0].Columns["Product_Category"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void fetch_Model()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Model_No from tlb_Model where P_Category='"+cmbP_PCategory .SelectedValue .GetHashCode()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_ModelNo.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_ModelNo  .ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_ModelNo.DisplayMemberPath = ds.Tables[0].Columns["Model_No"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnColorSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                baddprd.Flag = 1;
                baddprd.Model_No_ID  = Convert.ToInt32(cmbModelColor.SelectedValue.GetHashCode());
                baddprd.Color  = txtcolor.Text;
                baddprd.S_Status = "Active";
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd.AddColor_Insert_Update_Delete (baddprd);
                MessageBox.Show("Data Save Successfully");
                txtcolor.Text = "";
                cmbDomainColor.SelectedValue = null;
                cmbProductColor.SelectedValue = null;
                cmbBrandColor.SelectedValue = null;
                cmbPCategoryColor.SelectedValue = null;
                cmbModelColor.SelectedValue = null;

                Load_Domain();
               // fetch_Color();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Load_CDomain()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbDomainColor.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbDomainColor .ItemsSource = ds.Tables[0].DefaultView;
                    cmbDomainColor.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_CProduct()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Domain_ID, Product_Name from tlb_Products where Domain_ID='" + cmbDomainColor.SelectedValue .GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbProductColor.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbProductColor .ItemsSource = ds.Tables[0].DefaultView;
                    cmbProductColor.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_CBrand()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Product_ID, Brand_Name from tlb_Brand where Product_ID='" + cmbProductColor.SelectedValue.GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbBrandColor.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbBrandColor .ItemsSource = ds.Tables[0].DefaultView;
                    cmbBrandColor.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_CPC()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,Brand_ID, Product_Category from tlb_P_Category where Brand_ID='" + cmbBrandColor.SelectedValue .GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPCategoryColor.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPCategoryColor .ItemsSource = ds.Tables[0].DefaultView;
                    cmbPCategoryColor.DisplayMemberPath = ds.Tables[0].Columns["Product_Category"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void Load_CModel()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID,P_Category, Model_No from tlb_Model where P_Category='" + cmbPCategoryColor.SelectedValue .GetHashCode() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbModelColor.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbModelColor .ItemsSource = ds.Tables[0].DefaultView;
                    cmbModelColor.DisplayMemberPath = ds.Tables[0].Columns["Model_No"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void fetch_Color()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Color from tlb_Color where Model_No_ID='"+cmbP_ModelNo .SelectedValue .GetHashCode()+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbP_Color.SelectedValuePath  = ds.Tables[0].Columns["ID"].ToString();
                    cmbP_Color.ItemsSource = ds.Tables[0].DefaultView;
                    cmbP_Color.DisplayMemberPath = ds.Tables[0].Columns["Color"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void cmbDomainColor_DropDownClosed(object sender, EventArgs e)
        {
                    }

        private void cmbProductColor_DropDownClosed(object sender, EventArgs e)
        {
            Load_CBrand();
        }

        private void cmbBrandColor_DropDownClosed(object sender, EventArgs e)
        {
            Load_CPC();
        }

        private void cmbPCategoryColor_DropDownClosed(object sender, EventArgs e)
        {
            Load_CModel();
        }

        private void cmbDomainModelno_DropDownClosed(object sender, EventArgs e)
        {
                    }

        private void cmbProductModelno_DropDownClosed(object sender, EventArgs e)
        {
                   }

        private void cmbBrandModelno_DropDownClosed(object sender, EventArgs e)
        {
                   }
        //Main Save 
        private void btnP_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                baddprd.Flag = 1;
                baddprd.Domain_ID  = Convert.ToInt32 (cmbP_domain.SelectedValue .GetHashCode ());
                baddprd.Product_ID = Convert.ToInt32(cmbP_Product.SelectedValue.GetHashCode());
                baddprd.Brand_ID = Convert.ToInt32(cmbP_Brand.SelectedValue.GetHashCode());
                baddprd.P_Category = Convert.ToInt32(cmbP_PCategory.SelectedValue.GetHashCode());
                baddprd.Model_No_ID = Convert.ToInt32(cmbP_ModelNo.SelectedValue.GetHashCode());
                baddprd.Color_ID = Convert.ToInt32(cmbP_Color.SelectedValue.GetHashCode());
                baddprd.Narration = txtP_Narration.Text;
                baddprd.Price =Convert .ToDouble ( txtP_Price.Text);
                baddprd.S_Status = "Active";
                baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dalprd.Save_Insert_Update_Delete(baddprd);
                MessageBox.Show("Data Save Successfully");
                txtP_Narration .Text = "";
                txtP_Price.Text = "";
                clearAllADDProducts();
               // Load_Domain();
               
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void cmbP_domain_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void cmbP_Product_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void cmbP_Brand_DropDownClosed(object sender, EventArgs e)
        {
            Fetch_PC();
        }

        private void cmbP_PCategory_DropDownClosed(object sender, EventArgs e)
        {
           

        }

        private void cmbP_ModelNo_DropDownClosed(object sender, EventArgs e)
        {
            
        }
        public void clearAllADDProducts()
        {
            cmbP_domain.SelectedValue = null;
            cmbP_Product.SelectedValue = null;
            cmbP_Brand.SelectedValue = null;
            cmbP_PCategory.SelectedValue = null;
            cmbP_ModelNo.SelectedValue = null;
            cmbP_Color.SelectedValue = null;
            Load_Domain();
        }
        private void smnewprocurement_Click(object sender, RoutedEventArgs e)
        {
            GRD_NewProcurement.Visibility = Visibility;
           // load_DSelect();
            load_DSelect();
            Fetch_Pre_Domain();
            load_Insurance();
            load_Followup();
            

          

        }

        private void cmbDomainBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbProductBrand.SelectedValue = null;
            Load_BrandProduct();

        }

        private void cmbDomainPCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbBrandPCategory.SelectedValue = null;
            cmbPrePCategory.SelectedValue = null;
            Load_PCProduct();
        }

        private void cmbProductPCategoryy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Load_PCBrand();
        }

        private void cmbDomainModelno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbProductModelno.SelectedValue = null;
            cmbBrandModelno.SelectedValue = null;
            cmbPCategoryModelno.SelectedValue = null;
            Load_MProduct();
        }

        private void cmbProductModelno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbBrandModelno.SelectedValue = null;
            cmbPCategoryModelno.SelectedValue = null;
            Load_MBrand();
        }

        private void cmbBrandModelno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPCategoryModelno.SelectedValue = null;
            Load_MPC();
        }

        private void cmbPCategoryModelno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbDomainColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbProductColor.SelectedValue = null;
            cmbBrandColor.SelectedValue = null;
            cmbPCategoryColor.SelectedValue = null;
            cmbModelColor.SelectedValue = null;
            Load_CProduct();
        }

        private void cmbProductColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //cmbProductColor.SelectedValue = null;
            cmbBrandColor.SelectedValue = null;
            cmbPCategoryColor.SelectedValue = null;
            cmbModelColor.SelectedValue = null;
            
            Load_CBrand();
        }

        private void cmbBrandColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPCategoryColor.SelectedValue = null;
            cmbModelColor.SelectedValue = null;
            Load_CPC();
        }

        private void cmbPCategoryColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbModelColor.SelectedValue = null;
            Load_CModel();

        }

        private void cmbP_domain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbP_Product.SelectedValue = null;
            cmbP_Brand.SelectedValue = null;
            cmbP_PCategory.SelectedValue = null;
            cmbP_ModelNo.SelectedValue = null;
            cmbP_Color.SelectedValue = null;
           Fetch_Product();
        }

        private void cmbP_Product_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            cmbP_Brand.SelectedValue = null;
            cmbP_PCategory.SelectedValue = null;
            cmbP_ModelNo.SelectedValue = null;
            cmbP_Color.SelectedValue = null;
            fetch_Brand();
            
            //fetch_Model();
           
        }

        private void cmbP_Brand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbP_PCategory.SelectedValue = null;
            cmbP_ModelNo.SelectedValue = null;
            cmbP_Color.SelectedValue = null;
            Fetch_PC();
        }

        private void cmbP_PCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbP_ModelNo.SelectedValue = null;
            cmbP_Color.SelectedValue = null;
            fetch_Model();
        }

        private void cmbP_ModelNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbP_Color.SelectedValue = null;
            fetch_Color();
        }

        private void btnPro_Exit_Click(object sender, RoutedEventArgs e)
        {
            GRD_NewProcurement.Visibility = Visibility.Hidden;
            clearallPreProcurement();
        }
        //=============== new pre procuremnet=================
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbox = sender as CheckBox;
            string s = cbox.Content as string;

            if ((bool)cbox.IsChecked)
                checkedStuff.Add(s);
            else
                checkedStuff.Remove(s);
        }
        private void btnPro_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bpreproc.Flag = 1;
                //bpreproc.Saler_Name = txtsalername.Text;//cmbPre_Saler .SelectedValue.ToString();
               //bpreproc.Phone_Id = txtprephone .Text ;
                bpreproc.Domain_ID = Convert.ToInt32(cmbPreDomain .SelectedValue.GetHashCode());
                bpreproc.Product_ID = Convert.ToInt32(cmbPreProduct .SelectedValue.GetHashCode());
                bpreproc.Brand_ID = Convert.ToInt32(cmbPreBrand.SelectedValue.GetHashCode());
                bpreproc.P_Category = Convert.ToInt32(cmbPrePCategory.SelectedValue.GetHashCode());
                bpreproc.Model_No_ID = Convert.ToInt32(cmbPreModel .SelectedValue.GetHashCode());
                bpreproc.Color_ID = Convert.ToInt32(cmd_PreColor.SelectedValue.GetHashCode());

                bpreproc.Procurment_Price = Convert .ToDouble (txtPrice .Text);
            //    for (int i = 0; i < 5;i++ )
            //    { 
            //        if (chkidproof.IsChecked == true)
            //        {
            //            maincked = "ID Proof";
            //        }
              
            //    if(chkaddressproof  .IsChecked ==true )
            //    {
            //        maincked = "Address Proof";
            //    }
            //        string concate += ","+item maincked;
            //}
                string checkList = string.Join(",", checkedStuff.ToArray());
                if (checkList == null)
                { bpreproc.Reg_Document = "No"; }
                else if (checkList != null)
                {
                    bpreproc.Reg_Document = checkList;
                }
                bpreproc.Have_Insurance = cmbPreInsurance .SelectedValue .ToString ();
                bpreproc.re_ferb_cost =Convert .ToDouble ( txtPreFerbcost.Text);
                bpreproc.Follow_up = cmbPreFollowup.SelectedValue.ToString();
                bpreproc.Narration = txtnarration.Text;
                bpreproc.S_Status = "Active";
                bpreproc.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                dpreproc.Pre_Procurement_Save_Insert_Update_Delete(bpreproc);
                MessageBox.Show("Data Save Successfully");
                txtP_Narration.Text = txtnarration .Text ;
                txtP_Price.Text = "";
                clearallPreProcurement();
                PREPROCUREMENTid();
                Fetch_Pre_Domain();


                //baddprd.Flag = 1;
                //baddprd.Domain_Name = cmbP_domain.SelectedValue.ToString ();
                //baddprd.Product_Name = cmbP_Product.SelectedValue.ToString();
                //baddprd.Brand_Name = cmbP_Brand.SelectedValue.ToString();
                //baddprd.Product_Category = cmbP_PCategory.SelectedValue.ToString();
                //baddprd.Model_No = cmbP_ModelNo.SelectedValue.ToString();
                //baddprd.Color = cmbP_Color.SelectedValue.ToString();
                //baddprd.Narration = txtP_Narration.Text;
                //baddprd.Price = Convert.ToDouble(txtP_Price.Text);
                //baddprd.S_Status = "Active";
                //baddprd.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                //dalprd.Save_Insert_Update_Delete(baddprd);
                //MessageBox.Show("Data Save Successfully");
                //txtP_Narration.Text = "";
                //txtP_Price.Text = "";
                // Load_Domain();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void fetch_Documents()
        {

            try
            { 
                con.Open();
             
                cmd = new SqlCommand("Select PAN_Card,Adhar_Card,Passport,Address_Proof,Seven_Twevel,Form_16,Dealer_Lisence,Other_ID_Proof,No_Documents,Cmp_ID_Proof  from tb_Domain where ID='" + cmbPreDomain.SelectedValue.GetHashCode() + "' ", con);
              
                SqlDataReader dr = cmd.ExecuteReader();
             
                while(dr.Read ())
             
                {
                    string p = dr["PAN_Card"].ToString ();
                    string ad = dr["Adhar_Card"].ToString();
                    string pa = dr["Passport"].ToString();
                    string addr = dr["Address_Proof"].ToString();
                    string st = dr["Seven_Twevel"].ToString();
                    string frm = dr["Form_16"].ToString();
                    string dl = dr["Dealer_Lisence"].ToString();
                    string oidp = dr["Other_ID_Proof"].ToString();
                    string nod = dr["No_Documents"].ToString();
                    string cmpid = dr["Cmp_ID_Proof"].ToString();
                 if(p=="Yes")
                    {
                        chkPANCARD.IsEnabled = true;
                        //chkPANCARD.IsChecked = true;
                    }
                 if (pa == "Yes")
                 {
                     chkPASSPORT .IsEnabled = true;
                 }
                 if (ad == "Yes")
                 {
                     CHKADHARC .IsEnabled = true;
                     //chkPANCARD.IsChecked = true;
                 }
                 if (addr == "Yes")
                 {
                     chkaddressproof.IsEnabled = true;
                 }
                 if (st == "Yes")
                 {
                     chk7_12.IsEnabled = true;
                 }
                 if (frm == "Yes")
                 {
                     chkform_16 .IsEnabled = true;
                 }
                 if (dl == "Yes")
                 {
                     chkDEALERL .IsEnabled = true;
                 }
                 if (oidp == "Yes")
                 {
                     chkOTHERID .IsEnabled = true;
                 }
                 if (nod == "Yes")
                 {
                     chkNODOCS .IsEnabled = true;
                 }
                 if (cmpid == "Yes")
                 {
                     chkcmpid.IsEnabled = true;
                 }
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }


        }
        private void cmbPreDomain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fetcdoc = cmbPreDomain.SelectedValue.GetHashCode();
            cmbPreProduct.SelectedValue = null;
            cmbPrePCategory.SelectedValue = null;
            cmbPreBrand.SelectedValue = null;
            cmbPreModel.SelectedValue = null;
            cmd_PreColor.SelectedValue = null;
            fetch_Documents();
            Fetch_Pre_Product();
         
        }
        public void Fetch_Pre_Domain()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Domain_Name from tb_Domain ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                   // cmbPreDomain.Text = "--Select--";
                    cmbPreDomain .SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPreDomain.ItemsSource = ds.Tables[0].DefaultView;
                    cmbPreDomain.DisplayMemberPath = ds.Tables[0].Columns["Domain_Name"].ToString();
                   // cmbPreDomain.Items.Insert(0, "--Select--");
                   // cmbPreDomain.Items.Insert(0, new ListItem("--Select--", "0"));
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Fetch_Pre_Product()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Product_Name from tlb_Products where Domain_ID='"+cmbPreDomain .SelectedValue .GetHashCode ()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPreProduct.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPreProduct.ItemsSource = ds.Tables[0].DefaultView;
                    cmbPreProduct.DisplayMemberPath = ds.Tables[0].Columns["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void fetch_Pre_Brand()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Brand_Name from tlb_Brand where Product_ID='"+cmbPreProduct .SelectedValue .GetHashCode ()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPreBrand .SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPreBrand.ItemsSource = ds.Tables[0].DefaultView;
                    cmbPreBrand.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }

        }
        public void Fetch_Pre_PC()
        {

            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT  ID,Product_Category from tlb_P_Category where Brand_ID='"+cmbPreBrand .SelectedValue .GetHashCode ()+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPrePCategory .SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPrePCategory.ItemsSource = ds.Tables[0].DefaultView;
                    cmbPrePCategory.DisplayMemberPath = ds.Tables[0].Columns["Product_Category"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }

        public void fetch_Pre_Model()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Model_No from tlb_Model where P_Category='"+cmbPrePCategory .SelectedValue .GetHashCode ()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbPreModel .SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmbPreModel.ItemsSource = ds.Tables[0].DefaultView;
                    cmbPreModel.DisplayMemberPath = ds.Tables[0].Columns["Model_No"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
        public void fetch_Pre_Color()
        {
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("Select DISTINCT ID, Color from tlb_Color where Model_No_ID='"+cmbPreModel .SelectedValue .GetHashCode()+"' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmd_PreColor.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmd_PreColor.ItemsSource = ds.Tables[0].DefaultView;
                    cmd_PreColor.DisplayMemberPath = ds.Tables[0].Columns["Color"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            finally
            {
                con.Close();
            }
        }
      
          public void load_Insurance()
        {
            cmbPreInsurance.Text = "--Select--";
            cmbPreInsurance.Items.Add("Yes");
            cmbPreInsurance.Items.Add("No");

        }
          public void load_Followup()
          {
              cmbPreFollowup.Text = "--Select--";
              cmbPreFollowup.Items.Add("Default");
              cmbPreFollowup.Items.Add("Custom");

          }
        public void load_DSelect()
          { cmbPreDomain.Text = "--Select--";
          cmbPreProduct.Text = "--Select--";
          cmbPreBrand.Text = "--Select--";
          cmbPrePCategory.Text = "--Select--";
          cmbPreModel.Text = "--Select--";
          cmd_PreColor.Text = "--Select--";
        }
        private void cmbPrePCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //cmbPreBrand.SelectedValue = null;
            cmbPreModel.SelectedValue = null;
            cmd_PreColor.SelectedValue = null;
            fetch_Pre_Model();
        }

        private void cmbPreProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPrePCategory.SelectedValue = null;
            cmbPreBrand.SelectedValue = null;
            cmbPreModel.SelectedValue = null;
            cmd_PreColor.SelectedValue = null;
            
            fetch_Pre_Brand();
        }

        private void cmbPreBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPrePCategory.SelectedValue = null;
            cmbPreModel.SelectedValue = null;
            cmd_PreColor.SelectedValue = null;
            Fetch_Pre_PC();
        }

        private void cmbPreModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmd_PreColor.SelectedValue = null;
            fetch_Pre_Color();
        }

        private void btnP_Clear_Click(object sender, RoutedEventArgs e)
        {
            clearAllADDProducts();
        }
        public void clearallPreProcurement()
        {
            cmbPreDomain.SelectedValue = null;
            cmbPreProduct.SelectedValue = null;
            cmbPrePCategory.SelectedValue = null;
            cmbPreBrand.SelectedValue = null;
            cmbPreModel.SelectedValue = null;
            cmd_PreColor.SelectedValue = null;
            txtprephone.Text = "";
            txtPreFerbcost.Text = "";
            txtnarration.Text = "";
            //chkidproof.IsChecked = false;
            //chkNodoc.IsChecked = false;
           // chkAddress__Proof.IsChecked = false;
           // chketc.IsChecked = false;
           // chkForm16.IsChecked = false;
            chkNODOCS.IsEnabled = false;
            chkPANCARD .IsEnabled = false;
            chkPASSPORT.IsEnabled = false;
            CHKADHARC.IsEnabled = false;
            chkOTHERID.IsEnabled = false;
            chkform_16.IsEnabled = false;
            chkDEALERL.IsEnabled = false;
            chkaddressproof.IsEnabled = false;
            chk7_12.IsEnabled = false;
            chkNODOCS.IsEnabled = false;
            chk7_12.IsChecked = false;
            cmbPreInsurance.SelectedValue = null;
            cmbPreFollowup.SelectedValue = null;
            load_Insurance();
            load_Followup();
            txtPrice.Text = "";
            chkcmpid .IsEnabled = false;
        }
        private void btnPro_Clear_Click(object sender, RoutedEventArgs e)
        {
            clearallPreProcurement();
        }

        private void cmd_PreColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             con.Open();

             cmd = new SqlCommand("Select  Price from Pre_Products where Color_ID='" + cmd_PreColor.SelectedValue.GetHashCode() + "' ", con);
              
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtPrice.Text  =dr["Price"].ToString ();
                }
                con.Close();
        }
        //===================code for customer and followup form===========================
        private void btnCSave_Click(object sender, RoutedEventArgs e)
        {
            if (rdoCCustom.IsChecked == true)
       {
            AddCustomerFollowup1();
            //Followup_Method();
        }
            else if (rdoCFolloup .IsChecked == true)
        {
        //    AddCustomerWalkin();
                 AddCustomerFollowup2();
        //    Walking_Method();
        }
        }

        private void GRD_Follwup_Loaded(object sender, RoutedEventArgs e)
        {
            GRD_Follwupandnew.Visibility = Visibility;
            load_Followup();
           FolloupID_fetch();
             
        }
        public void AddCustomerFollowup1()
        {
            balfollow.Flag = 1;
            balfollow.Followup_ID = lblwalkin .Content.ToString();
            balfollow.Name = txtCName.Text;
            balfollow.Mobile_No = txtCMobile.Text;
            balfollow.Date_Of_Birth = dp_Dob.SelectedDate.Value ;
            balfollow.Email_ID = txtCEmailid.Text;
            balfollow.Address = txtCAddress.Text;
            if(rdoBusiness .IsChecked ==true )
            {
                 bpg="Business";
            }
            else if (rdoCPrivate .IsChecked ==true )
            {
                bpg="Private Employee";
            }
                else if(rdoCgovt .IsChecked==true )
                {
                     bpg="Govt Employee";

                }
           
             balfollow.Occupation =bpg   ;
             balfollow.Product_Details = txtCProductDetails.Text;
             //balfollow.Followup_Walkin_Option = "Followup"; 
            
            //if(rdoCFolloup .IsChecked  ==true )
            //{
         //  balfollow.Followup_Type = "Default";
            //    //balfollow.F_Date = Convert.ToDateTime(dp_Cdate .SelectedDate =null);
            //   // balfollow.F_Message = "";
            //}
             if (rdoCCustom .IsChecked == true )
            {
                balfollow.Followup_Type = "Custom";
                balfollow.F_Date = dp_Cdate.SelectedDate.Value;
                balfollow.F_Message = txtCMessage.Text;
            }
            balfollow.Folloup_Update = "F_Active";
            balfollow.S_Status = "Active";
            balfollow.C_Date =Convert .ToDateTime ( System.DateTime.Now.ToShortDateString());
            dalfollow.Follwup1_Save_Insert_Update_Delete(balfollow);
            MessageBox .Show ("Customer Added sucsessfully ",caption , MessageBoxButton.OK);
            clearfunctionforfollowup();

        }
        public void AddCustomerFollowup2()
        {
            balfollow.Flag = 1;
            balfollow.Followup_ID = lblwalkin.Content.ToString();
            balfollow.Name = txtCName.Text;
            balfollow.Mobile_No = txtCMobile.Text;
            balfollow.Date_Of_Birth = dp_Dob.SelectedDate.Value;
            balfollow.Email_ID = txtCEmailid.Text;
            balfollow.Address = txtCAddress.Text;
            if (rdoBusiness.IsChecked == true)
            {
                bpg = "Business";
            }
            else if (rdoCPrivate.IsChecked == true)
            {
                bpg = "Private Employee";
            }
            else if (rdoCgovt.IsChecked == true)
            {
                bpg = "Govt Employee";

            }

            balfollow.Occupation = bpg;
            balfollow.Product_Details = txtCProductDetails.Text;
            //balfollow.Followup_Walkin_Option = "Followup"; 

            if (rdoCFolloup.IsChecked == true)
            {
               balfollow.Followup_Type = "Default";
                //balfollow.F_Date = Convert.ToDateTime(dp_Cdate .SelectedDate =null);
                // balfollow.F_Message = "";
            }
            //else if (rdoCCustom.IsChecked == true)
            //{
            //    balfollow.Followup_Type = "Custom";
            //    balfollow.F_Date = dp_Cdate.SelectedDate.Value;
            //    balfollow.F_Message = txtCMessage.Text;
            //}
            balfollow.Folloup_Update = "F_Active";
            balfollow.S_Status = "Active";
            balfollow.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            dalfollow.Follwup2_Save_Insert_Update_Delete(balfollow);
            MessageBox.Show("Customer Added sucsessfully ", caption, MessageBoxButton.OK);
            clearfunctionforfollowup();

        }

        private void smaddfolloup_Click(object sender, RoutedEventArgs e)
        {
            FolloupID_fetch();
        }
        //public void AddCustomerWalkin()
        //{
        //    balfollow.Flag = 2;
        //    balfollow.Followup_ID = LBLWALKIN.Content.ToString();
        //    balfollow.Name = txtCName.Text;
        //    balfollow.Mobile_No = txtCMobile.Text;
        //    balfollow.Date_Of_Birth = dp_Dob.SelectedDate.Value;
        //    balfollow.Email_ID = txtCEmailid.Text;
        //    balfollow.Address = txtCAddress.Text;
        //    if (rdoBusiness.IsChecked == true)
        //    {
        //        bpg = "Business";
        //    }
        //    else if (rdoCPrivate.IsChecked == true)
        //    {
        //        bpg = "Private Employee";
        //    }
        //    else if (rdoCgovt.IsChecked == true)
        //    {
        //        bpg = "Govt Employee";

        //    }

        //    balfollow.Occupation = bpg;
        //    balfollow.Followup_Walkin_Option = "Walkin";
        //   // balfollow.Followup_Type = cmbCFollowup.SelectedValue.ToString();
        //    balfollow.Walkins = "New_Walkin";
        //    balfollow.Folloup_Update = "W_IN";
        //    balfollow.S_Status = "Active";
        //    balfollow.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
        //    dalfollow.Customer_Walking_Save_Insert_Update_Delete (balfollow);
        //    MessageBox.Show("Customer Added sucsessfully ", caption, MessageBoxButton.OK);
        //}
    //public void Followup_Method()
    //    {
    //        balfollow.Flag = 3;
    //        balfollow.Cust_ID = "";
    //        balfollow.Followup_Type = cmbCFollowup.SelectedValue.ToString();
    //        if (cmbCFollowup.SelectedValue == "Default")
    //        {

    //        }
    //        else if (cmbCFollowup.SelectedValue == "Custom")
    //        {
    //            balfollow.F_Date = dp_Cdate.SelectedDate.Value;
    //            balfollow.F_Message = txtCMessage.Text;
    //        }
    //        balfollow.S_Status = "Active";
    //        balfollow.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
    //        dalfollow.Followup_Save_Insert_Update_Delete(balfollow );
    //        MessageBox.Show("Follow_up Added sucsessfully ", caption, MessageBoxButton.OK);
    //    }
    //    public void Walking_Method()
    //{
    //    balfollow.Flag = 3;
    //    balfollow.Cust_ID = "";
    //    balfollow.Walkins = "W_IN";
    //    balfollow.S_Status = "Active";
    //    balfollow.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
    //    dalfollow.walkin_Save_Insert_Update_Delete(balfollow);
    //    MessageBox.Show("Walk_in  Added sucsessfully ", caption, MessageBoxButton.OK);
    //}
        public void clearfunctionforfollowup()
        {
            FolloupID_fetch();
            txtCName.Text = "";
            txtCMobile.Text = "";
            txtCAddress.Text = "";
            txtCEmailid.Text  = "";
            txtCMessage.Text = "";
            txtCMobile.Text = "";
            txtCProductDetails.Text = "";
            dp_Dob.SelectedDate = null;
            dp_Cdate.SelectedDate = null;
            dp_Cdate.Visibility = Visibility.Hidden ;
            txtCMessage.Visibility = Visibility.Hidden ;
            rdoCFolloup.IsChecked = false;
            rdoCCustom.IsChecked = false;
            rdoBusiness.IsChecked = false;
            rdoCgovt.IsChecked = false;
            rdoCPrivate.IsChecked = false;



        }

        private void btnCClear_Click(object sender, RoutedEventArgs e)
        {
            clearfunctionforfollowup();
        }

        private void rdoCCustom_Checked(object sender, RoutedEventArgs e)
        {
           // dp_Cdate.IsEnabled = true;
           // txtCMessage.IsEnabled = true;
            dp_Cdate.Visibility = Visibility;
            txtCMessage.Visibility = Visibility;
        }

        private void btnCExit_Click(object sender, RoutedEventArgs e)
        {
            GRD_Follwupandnew.Visibility = Visibility.Hidden;
        }

        private void rdoCFolloup_Checked(object sender, RoutedEventArgs e)
        {
            dp_Cdate.Visibility = Visibility.Hidden ;
            txtCMessage.Visibility = Visibility.Hidden ;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rdosalefollowupcustomer_Checked(object sender, RoutedEventArgs e)
        {
            if(rdosalefollowupcustomer .IsChecked==true )
            {
                txtsalesearchcname.IsEnabled = true;
                txtSalecustomerno.IsEnabled = true;
            }
        }
      //===========================end followup code=========================
    }
}