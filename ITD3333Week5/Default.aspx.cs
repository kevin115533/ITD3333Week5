using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public int postCounter = 0;
    public object myUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        postCountLbl.Text = postCounter.ToString();
        postCountLbl.ForeColor = System.Drawing.Color.Red;
        postedNameLbl.Visible = false;
        postNameLbl.Visible = false;
        if (this.IsPostBack)
        {
            firstLbl.Visible = false;
            firstTxtbox.Visible = false;
            lastLbl.Visible = false;
            lastTxtbox.Visible = false;
            postedNameLbl.Visible = true;
            postNameLbl.Visible = true;
            myUser = (MyUserName)ViewState["user"];
            
        }
    }

    protected void Page_PreRender(Object sender, EventArgs e)
    {
        ViewState["user"] = myUser;
    }

    protected void cmdPostback_Click(object sender, EventArgs e)
    {
        
        if (ViewState["Counter"] == null)
        {
            postCounter = 1;
        }
        else
        {
            postCounter = (int)ViewState["Counter"] + 1;
        }
        ViewState["Counter"] = postCounter;
        postCountLbl.Text = postCounter.ToString();
        postCountLbl.ForeColor = System.Drawing.Color.Red;
        MyUserName myUser = new MyUserName(firstTxtbox.ToString(), lastTxtbox.ToString());
        ViewState["user"] = myUser;
    }

    [Serializable]
    public class MyUserName
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public MyUserName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }      
    }
}