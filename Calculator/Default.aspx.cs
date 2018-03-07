using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCalculator;

public partial class _Default : System.Web.UI.Page
{
    Calculator obj = new Calculator();
    int a, b, c;
    decimal e, f, g;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = obj.Add(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = obj.Sub(a, b);
        lblResult.Text = c.ToString();
    }
    protected void BtnMul_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = obj.Mul(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnDiv_Click(object sender, EventArgs ea)
    {
       
        e = Convert.ToDecimal(txtFno.Text);
        f = Convert.ToDecimal(txtSno.Text);
        g = obj.Div(e, f);
        lblResult.Text = g.ToString();
    }
}