using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default36 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEnter.Focus();
        btnAdd.Click += new EventHandler(btnAdd_Click);
        btn1.Click += new EventHandler(btn1_Click);
        btn2.Click += new EventHandler(btn2_Click);
        btn3.Click += new EventHandler(btn3_Click);
        btn4.Click += new EventHandler(btn4_Click);
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        if (rdb1.Checked)
        {
            string stringMatched = string.Empty;
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Text.ToLower() == txtEnter.Text.ToLower())
                {
                    stringMatched = txtEnter.Text ;
                    txtEnter.Text = string.Empty;
                    txtEnter.Focus();
                    break;
                }
            }
            if (stringMatched == string.Empty)
            {
                ListBox1.Items.Add(txtEnter.Text);
                lblResult.Text = "<p style='color:Green'>"+txtEnter.Text + " is Entered </p>";
                txtEnter.Text = string.Empty;
                txtEnter.Focus();

            }
            else
            {
                lblResult.Text = "<p style='color:red'>" +  stringMatched + " is already avalible in ListBox-1</p>";
            }
        }
        else if(rdb2.Checked)
        {
            string stringMatched = string.Empty;
            foreach (ListItem li in ListBox2.Items)
            {
                if (li.Text.ToLower() == txtEnter.Text.ToLower())
                {
                    stringMatched = txtEnter.Text;
                    break;
                }
            }
            if (stringMatched == string.Empty)
            {
                ListBox2.Items.Add(txtEnter.Text);
                lblResult.Text = "<p style='color:green'>"+ txtEnter.Text + " is Entered</p>";
                txtEnter.Text = string.Empty;
                txtEnter.Focus();

                
            }
            else
            {
               
                lblResult.Text ="<p style='color:red'>"+ stringMatched + " is already avalible in ListBox-2</p>";
            }
            
        }
    }
    //code for Button1

    protected void btn1_Click(object sender, EventArgs e)
    {
        lblResult.Text = string.Empty;
        string stringMatched = string.Empty;
        int flag = 0;
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected)
            {
                foreach (ListItem li in ListBox2.Items)
                {
                    if (ListBox1.Items[i].Text.ToLower() == li.Text.ToLower())
                    {
                        stringMatched += ListBox1.Items[i].Text + " ";
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    ListBox2.Items.Add(ListBox1.Items[i].Text);
                    ListBox1.Items.Remove(ListBox1.Items[i].Text);
                    i = i - 1;
                }
                else
                {
                    flag = 0;
                }
            }
        }
        if (stringMatched != string.Empty)
            lblResult.Text = "<p style='color:red'>" + stringMatched + " items already exists in ListBox-2 </p>";  
    }
    //code for Button2
    protected void btn2_Click(object sender, EventArgs e)
    {
        lblResult.Text = string.Empty;
        string stringMatched = string.Empty;
        int flag = 0;
        for (int i = 0; i < ListBox2.Items.Count; i++)
        {
            if (ListBox2.Items[i].Selected)
            {
                foreach (ListItem li in ListBox1.Items)
                {
                    if (ListBox2.Items[i].Text.ToLower() == li.Text.ToLower())
                    {
                        stringMatched += ListBox2.Items[i].Text + " ";
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    ListBox1.Items.Add(ListBox2.Items[i].Text);
                    ListBox2.Items.Remove(ListBox2.Items[i].Text);
                    i = i - 1;
                }
                else
                {
                    flag = 0;
                }
            }
        }
        if (stringMatched != string.Empty)
            lblResult.Text = "<p style='color:red'>" + stringMatched + " items already exists in ListBox-1 </p>";  


    }
    //code for Button 3
    protected void btn3_Click(object sender, EventArgs e)
    {
        lblResult.Text = string.Empty;
        string stringMatched = string.Empty;
        int flag = 0;
        
        for (int i = 0; i<ListBox1.Items.Count; i++)
        {
            
            foreach (ListItem li in ListBox2.Items)
            {
                if (ListBox1.Items[i].Text.ToLower() == li.Text.ToLower())
                {
                    stringMatched += ListBox1.Items[i].Text + "  ";
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                ListBox2.Items.Add(ListBox1.Items[i].Text);
                ListBox1.Items.Remove(ListBox1.Items[i].Text);
                i = i - 1;
            }
            else
            {
                flag = 0;
            }
        }
        if (stringMatched != string.Empty)
            lblResult.Text = "<p style='color:red'>" + stringMatched + " items already exists in ListBox-2 </p>";
       
    }

    // code for button 4
    protected void btn4_Click(object sender, EventArgs e)
    {
        lblResult.Text = string.Empty;
        string stringMatched = string.Empty;
        int flag = 0;

        for (int i = 0; i < ListBox2.Items.Count; i++)
        {

            foreach (ListItem li in ListBox1.Items)
            {
                if (ListBox2.Items[i].Text.ToLower() == li.Text.ToLower())
                {
                    stringMatched += ListBox2.Items[i].Text + " ";
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                ListBox1.Items.Add(ListBox2.Items[i].Text);
                ListBox2.Items.Remove(ListBox2.Items[i].Text);
                i = i - 1;
            }
            else
            {
                flag = 0;
            }
        }
        if (stringMatched != string.Empty)
            lblResult.Text = "<p style='color:red'>" + stringMatched + " items already exists in ListBox-1</p>";
    }
}