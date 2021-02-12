using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public int postCounter = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        postCountLbl.Text = postCounter.ToString();
        postCountLbl.ForeColor = System.Drawing.Color.Red;
        if (this.IsPostBack)
        {
            
        }
    }

    protected void Page_PreRender(Object sender, EventArgs e)
    {
        //ViewState["user"] = user;
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
        UserName user = new UserName(firstTxtbox.ToString(), lastTxtbox.ToString());
        user = (UserName)ViewState["user"];
    }

    [Serializable]
    public class UserName
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
        public UserName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}