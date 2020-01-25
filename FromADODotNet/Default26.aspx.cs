using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class Default26 : System.Web.UI.Page
{
    SqlCommand cmd = null;
    SqlConnection cn = null;
    string strSqlCommand = string.Empty;
    string strImage;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string filename = string.Empty;
        string fileserverpath = string.Empty;

        if (FileUpload1.HasFile)
        {
            string filetype = FileUpload1.PostedFile.ContentType;
            if (filetype == "image/jpg" ||
                filetype == "image/jpeg" ||
                filetype == "image/gif" ||
                filetype == "image/png" ||
                filetype == "image/bmp")
            {
                int fileSize = FileUpload1.PostedFile.ContentLength;
                if (fileSize <= 2097152)//2MB MAX
                {
                    filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    string folderPath = Server.MapPath("ProductImages/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    fileserverpath = folderPath + filename;
                }
                else
                {
                    lblStatus.Text = "image size should me maximum till 2MB";
                    return;
                }
            }
            else
            {
                lblStatus.Text = "please upload only image file";
                return;
            }
        }
        
        strSqlCommand= "Insert into Product (ProductNmae,ProductBrand,ProductPrice,ProductDesc,ProductImage)values(@ProductName,@productBrand,@ProductPrice,@ProductDesc,@ProductImage)";
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.Parameters.AddWithValue("ProductName", txtProductName.Text.Trim());
        cmd.Parameters.AddWithValue("ProductBrand", txtProductBrand.Text.Trim());
        cmd.Parameters.AddWithValue("ProductPrice", txtProductPrice.Text.Trim());
        cmd.Parameters.AddWithValue("ProductDesc", txtProductDesc.Text.Trim());
        cmd.Parameters.AddWithValue("ProductImage", filename);
        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            FileUpload1.SaveAs(fileserverpath);
            lblStatus.Text = "successful";
            txtProductBrand.Text = txtProductDesc.Text = txtProductName.Text = txtProductPrice.Text = string.Empty;
        }
        else
        {
            lblStatus.Text = "Product Saving Failed";
        }
        cn.Close();
    }
}