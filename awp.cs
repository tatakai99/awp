// 1 create an application that obtain four int values from the users and displays the product.
protected void Button1_Click(object sender, EventArgs e) {
	int num1, num2, num3, num4, prod;
	num1 = Convert.ToInt32(TextBox1.Text);
	num2 = Convert.ToInt32(TextBox2.Text);
	num3 = Convert.ToInt32(TextBox3.Text);
	num4 = Convert.ToInt32(TextBox4.Text);
	prod = num1 * num2 * num3 * num4;
	TextBox5.Text = Convert.ToString(prod);
}

// 2 Create an application to demonstrate string operations.
protected void Button1_Click(object sender, EventArgs e) {
	string str1 = TextBox1.Text;
	string[] words = str1.Split();
	for (int i = 0; i < words.Length; i++) {
		TextBox2.Text = TextBox2.Text + words[i] + "\n\r";
	}
}

// 3 Create an application that receive the (Student Id, Student Name, Course Name, Date of Birth) information from a set of students. The application should also dislplay the information of all the students once the data entered.
struct Student {
	public string studid, name, cname;
	public string dob;
}
public partial class Student_Information : System.Web.UI.Page {
	Student[] s = new Student[1];
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e)
	{
		int i;
		for ( i = 0; i < 1; i++ ) {
			s[i].studid = TextBox2.Text;
			s[i].name = TextBox3.Text;
			s[i].cname = TextBox4.Text;
			s[i].dob = TextBox5.Text;
		}
		for (i = 0; i < 1; i++) {
			Response.Write("\nStudent ID:" + s[i].studid + "<br>");
			Response.Write("\nStudent name:" + s[i].name + "<br>");
			Response.Write("\nCourse name:" + s[i].cname + "<br>");
			Response.Write("\nDate of Birth(dd-mm-yy):" + s[i].dob + "<br>");
			Response.Write("<br>");
			Response.Write("<br>");
		}
	}
}

// 1d_1 Create an application to demonstrate following operations
protected void Button1_Click(object sender, EventArgs e) {
	int num1 = 0, num2 = 1, num3, num4, num;
	num4 = int.Parse(TextBox1.Text); num = 3;
	Response.Write("Fiboncci sereis.");
	Response.Write(num1 + "\t" + num2);
	while (num <= num4) {
		num3 = num1 + num2;
		if (num >= num4)
			break;
		Response.Write("\t" + num3);
		num1 = num2; num2 = num3; num++;
	}
}

// 1d_2. Test for prime numbers.
protected void Button1_Click(object sender, EventArgs e) {
	int n, i, c;
	n = int.Parse(TextBox1.Text);
	for (c = 2; c <= n; c++) {
		if ((n % c) == 0)
			break;
	}
	if (n == 1)
		Response.Write(n + " is neither prime nor composite");
	else if (c < n - 1)
		Response.Write(n + " is not prime number");
	else
		Response.Write(n + "is prime number");
}

// 1d_3 Test for vowels.
protected void Button1_Click(object sender, EventArgs e) {
	String ch; int count = 0; ch = TextBox1.Text;
	for (int i = 0; i < ch.Length; i++) {
		if ((ch.Substring(i, 1) == "a") || (ch.Substring(i, 1) == "e") ||
		        (ch.Substring(i, 1) == "i") || (ch.Substring(i, 1) == "o") || (ch.Substring(i, 1) ==
		                "u")) {
			count++;
		}
	}
	Response.Write("Given String:\n" + ch + "<br>");
	Response.Write("Total Number of vowels:\n" + count + "<br>");
	Response.Write("<br>"); Response.Write("<br>");
}

// 1.d_4 se foreach loop with arrays.
protected void Button1_Click(object sender, EventArgs e) {
	int[] a = { 1, 2, 3, 4 };
	foreach (int x in a)
		Response.Write(x);
}

// 1.d_5 Reverse a number and find sum of digits of a number.
protected void Button1_Click(object sender, EventArgs e) {
	int num, actualnumber, revnum = 0, digit, sumDigits = 0;
	num = int.Parse(TextBox1.Text);	actualnumber = num;
	while (num > 0) {
		digit = num % 10;
		revnum = revnum * 10 + digit;
		sumDigits = sumDigits + digit;
		num = num / 10;
	}
	Response.Write("Reverse of\n" + actualnumber + "=" + revnum + "<br>");
	Response.Write("sum of its digits:\n" + sumDigits + "<br>");
}

// 2 Working With Object Oriented C# And ASP.NET.
// 2.a 2(a) Create simple application to perform follwoing operations.

protected void Button1_Click(object sender, EventArgs e) {
	int i, f = 1, num; num = Convert.ToInt32(TextBox1.Text);
	for (i = 1; i <= num; i++)
		f = f * i;
	Response.Write("\nFactorial of Given Number is:\n" + f);
	Response.Write("<br>");
}

// 2a_2 Money Conversion

public class Class1 {
	public double r, e, d;
	public Class1()	{	r = 0; e = 0; d = 0;	}
	public void convertdtor() {double ev = 60; r = d * ev;}
	public void convertetor() {double ev = 80; r = e * ev;}
	public void convertrtod() {double ev = 65; d = r / ev;}
	public void convertrtoe() {double ev = 80; e = r / ev;}
}

public partial class Currency_Converter : System.Web.UI.Page {
	Class1 f1;
	protected void Page_Load(object sender, EventArgs e) {f1 = new Class1();}
	protected void RadioButton2_CheckedChanged(object sender, EventArgs e) {
		if (RadioButton2.Checked == true) {
			f1.r = Convert.ToInt16(TextBox1.Text);
			f1.convertrtod();
			Response.Write(f1.r + "Rupee" + "=$" + f1.d);
		}
	}
	protected void RadioButton1_CheckedChanged(object sender, EventArgs e) {
		if (RadioButton1.Checked == true) {
			f1.d = Convert.ToInt16(TextBox1.Text);
			f1.convertdtor();
			Response.Write(f1.d + "Dollar" + "=Rs." + f1.r);
		}
	}
	protected void RadioButton3_CheckedChanged(object sender, EventArgs e) {
		if (RadioButton3.Checked == true) {
			f1.e = Convert.ToInt16(TextBox1.Text);
			f1.convertetor();
			Response.Write(f1.e + "Euro" + "=Rs." + f1.r);
		}
	}
	protected void RadioButton4_CheckedChanged(object sender, EventArgs e) {
		if (RadioButton4.Checked == true) {
			f1.r = Convert.ToInt16(TextBox1.Text);
			f1.convertrtoe();
			Response.Write(f1.r + "=Rs. to Euro" + f1.e);
		}
	}
}

// 2a_3 Quadratic Equatio
class Quadraticroots {
	public double a, b, c, r1, r2;
	public double compute() {
		int m; double d1;
		d1 = b * b - 4 * a * c;
		if (d1 == 0) {
			r1 = r2 = (-b) / (2 * a);
			return d1;
		} else if (d1 > 0) {
			r1 = (-b + Math.Sqrt(d1)) / (2 * a);
			r2 = (-b - Math.Sqrt(d1)) / (2 * a);
			return d1;
		} else {
			r1 = (-b) / (2 * a);
			r2 = Math.Sqrt(-d1) / (2 * a);
			return d1;
		}
	}
}

namespace practical {
public partial class Qudratic_equation : System.Web.UI.Page {
	Quadraticroots q;
	protected void Page_Load(object sender, EventArgs e) {
		q = new Quadraticroots();
	}
	protected void Button1_Click(object sender, EventArgs e) {
		q.a = Convert.ToInt16(TextBox1.Text);
		q.b = Convert.ToInt16(TextBox2.Text);
		q.c = Convert.ToInt16(TextBox3.Text);
		double d = q.compute();
		if (d == 0) {
			Response.Write("\n Roots are Real and Equal<br>");
			Response.Write("First root and second root is" + q.r1);
		}
		else if (d > 0) {
			Response.Write("\nRoots are Real and Distinct<br>");
			Response.Write("\nFirst Root is" + q.r1 + "<br>");
			Response.Write("\nSecond Root is" + q.r2 + "<br>");
		} else {
			Response.Write("\nRoots are Imaginary <br>");
			Response.Write("\nFirst Roots is" + q.r1 + "<br>");
			Response.Write("\nSecond Roots is" + q.r2 + "<br>");
		}
	}
}
}

// 2a_4 Temperature Conversion.

class converttemp {
	public float celsius, faren;
	public converttemp() {celsius = 0; faren = 0;}
	public void converttofaren() {faren = ((celsius * 9.0f / 5.0f) + 32.0f);}
	public void converttocel() {celsius = (faren - 32) * (5.0f / 9.0f);}
}
public partial class temperature_conversion : System.Web.UI.Page {
	converttemp c;
	protected void Page_Load(object sender, EventArgs e) {c = new converttemp();}
	protected void Button1_Click(object sender, EventArgs e) {
		char ch; ch = Convert.ToChar(TextBox1.Text);
		if (ch == 'c') {
			c.celsius = float.Parse(TextBox2.Text);
			c.converttofaren();
			Label1.Text = "Celsius to Farenheit\n" + c.faren;
		} else {
			c.faren = float.Parse(TextBox2.Text);
			c.converttocel();
			Label1.Text = "Farenheit to Celsius\n" + c.celsius;
		}
	}
}


// 2 Woriking With Object Oriented C# and ASP.NET
// 2.b Create simple application to demonstrate use of following concepts
// Function Overloading
class overloading {
	public int sum(int a, int b) {int x; return x = a + b;}
	public int sum(int a, int b, int c) {int y; return y = a + b + c;}
	public float sum(float a, float b) {float u; return u = a + b;}
	public float sum(float a, float b, float c) {float v; return v = a + b + c;}
}
public partial class functionoverloading : System.Web.UI.Page {
	overloading o;
	protected void Page_Load(object sender, EventArgs e) {o = new overloading();}
	protected void Button1_Click(object sender, EventArgs e) {
		Label1.Text = Convert.ToString(o.sum(10, 20));
		Label2.Text = Convert.ToString(o.sum(10, 20, 30));
		Label3.Text = Convert.ToString(o.sum(12.0f, 23.1f, 32.5f));
	}
}



// 2.b.2 nheritance (All Types)
// single

public class basec {
	public int d;
	public string basemethod() {string p = "This is baseclass method"; return p;}
}
public class Derived : basec {
	public string derivedmethod() {string s = "This is derivedclassmethod"; return s;}
}
public partial class singleInheritance : System.Web.UI.Page {
	protected void Button1_Click(object sender, EventArgs e) {
		basec b = new basec();
		Response.Write("Calling from base class object:" + b.basemethod());
		Derived d = new Derived();
		Response.Write("<br>Calling from derived class object:<br>" +
		               d.basemethod());
		Response.Write("<br>" + d.derivedmethod());
	}
}

// Multi Level Inheritance
class A {public string show() {return ("First base Class");}}
class B : A {public string display() {return ("Second base Class");}}
class C : B {public string show1() {return "Child Class";}}
public partial class MultiLevelInheritance : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		C obj = new C();
		Response.Write(obj.show() + "<br>");
		Response.Write(obj.display() + "<br>");
		Response.Write(obj.show1() + "<br>");
	}
}

// Multiple Inheritance
class Shape
{
	public int side;
	public void setSide(int s)
	{
		side = s;
	}
}
public interface Cost
{
	int getCost(int area);
}
class square : Shape, Cost
{
	public int getArea()
	{
		return (side * side);
	}
	public int getCost(int area)
	{
		return area * 10;
	}
}
public partial class MULTIPLE_INHERITANCE : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		square sq = new square();
		int area;
		sq.setSide(15);
		area = sq.getArea();
		Label1.Text = "Area:" + area;
		int c = sq.getCost(area);
		Label2.Text = "Cost is Rs:" + c;
	}
}

// Hierarchical Inheritance
class A
{
	public string show()
	{
		return "Welcome";
	}
}
class B : A
{
	public string display()
	{
		return "to the World";
	}
}
class C : A
{
	public string show1()
	{
		return "Of Programming";
	}
}
public partial class HIERARCHICAL_INHERITANCE : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		C c1 = new C();
		B b1 = new B();
		string s = "";
		s += c1.show();
		s += b1.display();
		s += c1.show1();
		Label1.Text = s;
	}
}

// constructor overloading
class MarkSheet {
	private float m1, m2, m3;
	string name;
	public MarkSheet() {m1 = 20; m2 = 40; m3 = 40;}
	public MarkSheet(float ms) {m1 = ms;}
	public MarkSheet(float ms1, float ms2) {m1 = ms1; m2 = ms2;}
	public MarkSheet(float ms1, float ms2, float ms3) {m1 = ms1; m2 = ms2; m3 = ms3;}
	public float tot() {float t = m1 + m2 + m3; return t;}
}
public partial class Constructor_Overloading : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		MarkSheet a = new MarkSheet();
		MarkSheet b = new MarkSheet(90);
		MarkSheet c = new MarkSheet(88, 60);
		MarkSheet d = new MarkSheet(70, 90, 55);
		Response.Write("In marksheet 1:");
		Response.Write(a.tot() + "<br>");
		Response.Write("In marksheet 2:");
		Response.Write(b.tot() + "<br>");
		Response.Write("In markseet 3:");
		Response.Write(c.tot() + "<br>");
		Response.Write("In marksheet 4:");
		Response.Write(d.tot() + "<br>");
	}
}


// Interface
public interface ITransactions
{
	string retcode();
	double amtfunc();
}
public class Transaction : ITransactions
{
	private string tCode;
	private double amount;
	public Transaction()
	{
		tCode = "";
		amount = 0.0;
	}
	public Transaction(string c, double a)
	{
		tCode = c;
		amount = a;
	}
	public double amtfunc()
	{
		return amount;
	}
	public string retcode()
	{
		return tCode;
	}
}
public partial class INTERFACE : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		Transaction t1 = new Transaction("Cr", 780.00);
		Transaction t2 = new Transaction("Db", 400.00);
		Response.Write("<br>Code" + t1.retcode());
		Response.Write("<br>Amount" + t1.amtfunc());
		Response.Write("<br>Code" + t2.retcode());
		Response.Write("<br>Amount:" + t2.amtfunc());
	}
}

// 2(c). Create simple applicaion to demonstrate use of following concepts
// i) Using Delegates and events
public partial class Delegates_Events : System.Web.UI.Page {
	public delegate void SimpleDelegate();
	public void callingFunction() {Response.Write("First Function Called....<br>");}
	public void secfunction() {Response.Write("Second Function Called...<br>");}
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		SimpleDelegate sd = new SimpleDelegate(callingFunction);
		sd(); sd += new SimpleDelegate(secfunction); sd();
	}
}

// ii) Exception Handling
class NegativeException : Exception {
	public NegativeException(string msg): base(msg)	{	}
}
public partial class Exception_Handling : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		int num;
		try	{
			num = int.Parse(TextBox1.Text);
			if (num < 0)
				throw new NegativeException("Negative Number");
			else
				Console.WriteLine("Positive Number");
		} catch (NegativeException en) {Response.Write(en.Message);}
	}
}

// Practical 3(b).Demonstrate the use of Calendar control to perform following operations
------------------------ aspx
/*<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender" ShowGridLines="True" Width="300px" OnSelectionChanged="Calendar1_SelectionChanged" >
<DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
<NextPrevStyle BorderStyle="Solid" BorderWidth="2px" Font-Size="9pt" ForeColor="#FFFFCC"/>
<OtherMonthDayStyle BackColor="#FFCC99" BorderStyle="Solid" ForeColor="#CC9966" />
<SelectedDayStyle BackColor="Red" Font-Bold="True" /> <SelectorStyle BackColor="#FFCC66" />
<TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
<TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
<WeekendDayStyle Height="50px" />
</asp:Calendar>*/

-------------------- - CS
protected void btnResult_Click(object sender, EventArgs e) {
	Calendar1.Caption = "SAMBARE";
	Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
	Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
	Calendar1.TitleFormat = TitleFormat.Month;
	Label2.Text = "Todays Date" + Calendar1.TodaysDate.ToShortDateString();
	Label3.Text = "Ganpati Vacation Start: 9-13-2018";
	TimeSpan d = new DateTime(2018, 9, 13) - DateTime.Now;
	Label4.Text = "Days Remaining For Ganpati Vacation:" + d.Days.ToString(); TimeSpan d1 = new	DateTime(2018, 12, 31) - DateTime.Now; Label5.Text = "Days Remaining for New Year:" + d1.Days.ToString();
	if (Calendar1.SelectedDate.ToShortDateString() == "9-13-2018")
		Label3.Text = "<b>Ganpati Festival Start</b>";
	if (Calendar1.SelectedDate.ToShortDateString() == "9-23-2018")
		Label3.Text = "<b>Ganpati Festival End</b>";
}
protected void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e) {
	if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9) {
		e.Cell.BackColor = System.Drawing.Color.Yellow;
		Label lbl = new Label();
		lbl.Text = "<br>Teachers Day!";
		e.Cell.Controls.Add(lbl);
		Image g1 = new Image();
		g1.ImageUrl = "td.jpg";
		g1.Height = 20; g1.Width = 20;
		e.Cell.Controls.Add(g1);
	}
	if (e.Day.Date.Day == 13 && e.Day.Date.Month == 9) {
		Calendar1.SelectedDate = new DateTime(2018, 9, 12);
		Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate, Calendar1.SelectedDate.AddDays(10));
		Label lbl1 = new Label();
		lbl1.Text = "<br>Ganpati!";
		e.Cell.Controls.Add(lbl1);
	}
}
protected void btnReset_Click(object sender, EventArgs e) {
	Label1.Text = "";
	Label2.Text = "";
	Label3.Text = "";
	Label4.Text = "";
	Label5.Text = "";
	Calendar1.SelectedDates.Clear();
}
protected void Calendar1_SelectionChanged(object sender, EventArgs e) {
	Label1.Text = "Your Selected Date:" +
	              Calendar1.SelectedDate.Date.ToString();
}


// Practical 3(c).Demonstrate the use of Treeview control perform following operations. : a) Treeview control and datalist b) Treeview operations
/*stdetail.xml
<?xml version="1.0" encoding="utf-8" ?>
<studentdetail>
<student>
<sid>1</sid>
<sname>Tushar</sname>
<sclass>TYIT</sclass>
</student>
<student>
<sid>2</sid>
<sname>Sonali</sname>
<sclass>TYCS</sclass>
</student>
<student>
<sid>3</sid>
<sname>Yashashree</sname>
<sclass>TYIT</sclass>
</student>
<student>
sid>4</sid>
<sname>Vedshree</sname>
<sclass>TYCS</sclass>
</student>
</studentdetail>*/
---- - aspx
/*<form id="form1" runat="server">
<div>
Treeview control navigation:<asp:TreeView ID = "TreeView1" runat
= "server" Width = "150px" ImageSet="Arrows">
<HoverNodeStyle Font-Underline="True"
ForeColor="#5555DD" /> <Nodes>
<asp:TreeNode Text = "ASP.NET Practs" Value = "New Node">
<asp:TreeNode Text = "Calendar Control" Value = "RED"
NavigateUrl="~/calndrCtrl.aspx"> </asp:TreeNode>
<asp:TreeNode Text = "Constructor Overloading" Value = "GREEN"
NavigateUrl="~/clsconstrc.aspx"> </asp:TreeNode>
<asp:TreeNode NavigateUrl="~/singleInh.aspx" Text="Inheritance"
Value="BLUE"></asp:TreeNode>
<asp:TreeNode NavigateUrl="~/clsProp.aspx" Text="Class
Properties" Value="Class Properties"></asp:TreeNode>
</asp:TreeNode>
</Nodes>
<NodeStyle Font-Names="Tahoma" Font-Size="10pt"
ForeColor="Black" HorizontalPadding="5px"
NodeSpacing="0px" VerticalPadding="0px" />
<ParentNodeStyle Font-Bold="False" />
<SelectedNodeStyle Font-Underline="True"
ForeColor="#5555DD" HorizontalPadding="0px"
VerticalPadding="0px" /> </asp:TreeView>
<br />
Fetch Datalist Using XML data :
</div> <asp:DataList
ID="DataList1" runat="server">
<ItemTemplate>
<table class = "table" border="1">
<tr>
<td>Roll Num : <%# Eval("sid") %><br />
Name : <%# Eval("sname") %><br />
Class : <%# Eval("sclass")%>
</td>
</tr>
</table>
</ItemTemplate>
</asp:DataList>
*/

---- - cs

using System.Data;
public partial class _Default:System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e){
		if (!IsPostBack){BindData();}
	}
	protected void BindData(){
		DataSet ds = new DataSet();
		ds.ReadXml(Server.MapPath("stdetail.xml"));
		if (ds != null && ds.HasChanges()){
			DataList1.DataSource = ds;
			DataList1.DataBind();
		}else{DataList1.DataBind();}
	}
}


// Practical 4(b).Create Web Form to demonstrate use of Adrotator Control. Add a XML file, name it "adds.xml"
/* ------------------- XML
<Advertisements>
<Ad>
<ImageUrl>rose1.jpg</ImageUrl>
<NavigateUrl>http://www.1800flowers.com</NavigateUrl>
<AlternateText>
Order flowers, roses, gifts and more
</AlternateText>
<Impressions>20</Impressions>
<Keyword>flowers</Keyword>
</Ad>
<Ad>
<ImageUrl>rose2.jpg</ImageUrl>
<NavigateUrl>http://www.babybouquets.com.a
u</NavigateUrl> <AlternateText>Order roses
and flowers</AlternateText>
<Impressions>20</Impressions>
<Keyword>gifts</Keyword>
</Ad>
<Ad>
<ImageUrl>rose3.jpeg</ImageUrl>
<NavigateUrl>http://www.flowers2moscow.co
m</NavigateUrl> <AlternateText>Send flowers
to Russia</AlternateText>
<Impressions>20</Impressions>
<Keyword>russia</Keyword>
</Ad>
</Advertisements>*/

/* ------------------- ASPX
<asp:AdRotator ID="AdRotator1" runat="server"
DataSourceID="XmlDataSource1" />
<asp:XmlDataSource ID="XmlDataSource1" runat="server"
DataFile="~/ADFILE.xml"></asp:XmlDataSource>
*/

// Practical 5(b).Create a web application to demonstrate use of Master Page with applying Styles and Themes for page beautification.
MasterPage.master
<%@ Master Language="C#"
AutoEventWireup="true"
CodeFile="MasterPage.master.cs"
Inherits="MasterPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Master Page Demo</title>
<link href="css/my.css" rel="stylesheet" />
<asp:ContentPlaceHolder ID="head" runat="server">
</asp:ContentPlaceHolder>
<style type="text/css">
.auto-style1 {
position: absolute;
top: 373px;
left: 1028px;
bottom: 303px;
}
.auto-style2 {
position: absolute;
top: 537px;
left: 1016px;
z-index: 1;
}
</style>
</head>
<body>
<!DOCTYPE html>
<form id="form1" runat="server">
<html>
<head>
<title>Master</title>
<link rel="stylesheet" type="text/css"
href="StyleSheet.css">
</head>
<body>
<header id="header">
<h1>Demo Of Master Page</h1>
</header>
<nav id="nav">
<ul>
<li><a href="home.aspx">Insight</a></li>
<li><a href="#">Products</a></li>
<li><a href="#">Downloads</a></li>
<li><a href="#">Contact Us</a></li>
</ul>
</nav>
<aside
id="side">
<h1>Info</
h1>
<a href="#"><p>Product Type 1</p></a>
<a href="#"><p>Product Type 2</p></a>
<a href="#"><p>Product Type 3<a
href="#"><asp:ScriptManager ID="ScriptManager1"
runat="server">
</asp:ScriptManager>
</a>
</p>
<asp:Button ID="Button2" runat="server"
CssClass="auto-style1" style="z-index: 1"
Text="Button" />
<asp:Button ID="Button1" runat="server"
CssClass="auto-style2" Text="Button" />
</aside>
<div id="con">
<asp:ContentPlaceHolder ID="ContentPlaceHolder1"
runat="server">
</asp:ContentPlaceHolder>
</div>
<footer id="footer">
copyright @Sambare
</footer>
</body>
</html>
</form>
</body>
</html>
/* -------------- MasterDisplay.aspx
<%@ Page Title="" Language="C#"
MasterPageFile="~/MasterPage.master"
AutoEventWireup="true"
CodeFile="MasterDisplay.aspx.cs"
Inherits="MasterDisplay" %>
<asp:Content ID="Content1"
ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"
ContentPlaceHolderID="ContentPlaceHolder1"
runat="server"> <h1>Home page</h1>
</asp:Content>
*/
/* StyleSheet.css
#header{
color: blueviolet;
text-align: center;
font-size: 20px;
}
#nav{
background-color:darkseagreen;
padding: 5px;
}
ul{
list-style-type: none;
}
li a {
color:crimson ;
font-size: 30px;
column-width: 5%;
}
li
{
display: inline;
padding-left: 2px;
column-width: 20px;
}
a{
	text-decoration: none;
margin-left:20px
}
li a:hover{
background-color: aqua;
color:coral ;
padding:1%;
}
#side{
text-align: center;
float: right;
width: 15%;
padding-bottom: 79%;
background-color: #F1FAEE;
}
#article{
background-color: burlywood;
padding: 10px;
padding-bottom: 75%;
}
#footer{
background-color: #C7EFCF;
text-align:center;
padding-bottom: 5%;
font-size: 20px;
}
#con{
border:double;
border-color:burlywood;
}
*/


// 6 : insert_read
------------------------------------------------------------ - pspx
/*< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "sqlpract6.WebForm1" % >

                      < !DOCTYPE html >

                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    < / div >
                                                    <asp: Label ID = "Label1" runat = "server" Text = "RollNo"> < / asp: Label >
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox1" runat = "server"> < / asp: TextBox >
                                      <p>
                                      <asp: Label ID = "Label2" runat = "server" Text = "Name"> < / asp: Label >
                                              &nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox2" runat = "server"> < / asp: TextBox >
                                      < / p >
                                      <p>
                                      <asp: Label ID = "Label3" runat = "server" Text = "Age"> < / asp: Label >
                                              &nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox3" runat = "server"> < / asp: TextBox >
                                      < / p >
                                      <p>
                                      <asp: Label ID = "Label4" runat = "server" Text = "city"> < / asp: Label >
                                              &nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox4" runat = "server"> < / asp: TextBox >
                                      < / p >
                                      <p>
                                      &nbsp; < / p >
< asp: Button ID = "Button1" runat = "server" OnClick = "Button1_Click" Text = "Insert" Width = "162px" / >
                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
< asp: Button ID = "Button2" runat = "server" OnClick = "Button2_Click" Text = "Button" / >
                                     &nbsp; <asp: SqlDataSource ID = "SqlDataSource1" runat = "server" ConnectionString = "<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand = "SELECT * FROM [studentData]"> < / asp: SqlDataSource >
                                             <asp: TextBox ID = "TextBox5" runat = "server" Height = "199px" TextMode = "MultiLine" Width = "376px"> < / asp: TextBox >
                                                     <asp: GridView ID = "GridView1" runat = "server" AutoGenerateColumns = "False" DataSourceID = "SqlDataSource1">
                                                             <Columns>
                                                             < asp: BoundField DataField = "ROLLNO" HeaderText = "ROLLNO" SortExpression = "ROLLNO" / >
                                                                     < asp: BoundField DataField = "NAME" HeaderText = "NAME" SortExpression = "NAME" / >
                                                                             < asp: BoundField DataField = "AGE" HeaderText = "AGE" SortExpression = "AGE" / >
                                                                                     < asp: BoundField DataField = "CITY" HeaderText = "CITY" SortExpression = "CITY" / >
                                                                                             < / Columns >
                                                                                             < / asp: GridView >
                                                                                             < / form >
                                                                                             < / body >
                                                                                             < / html >
*/


------------------------------------------------------------ - cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace sqlpract6 {
public partial class WebForm1 : System.Web.UI.Page {
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e) {  }
	protected void Button1_Click(object sender, EventArgs e) {
		try {
			string query = "INSERT INTO studentData values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
			SqlCommand cmd = new SqlCommand(query, con); con.Open(); cmd.ExecuteNonQuery();
			Response.Write("Data inserted succesfully");
		} catch (Exception x) {Response.Write(x);}
		finally {con.Close();}
	}
	protected void Button2_Click(object sender, EventArgs e) {
		try {
			string query = "select * from studentData";
			SqlCommand cmd = new SqlCommand(query, con);
			con.Open(); GridView1.DataBind();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read()) {
				TextBox5.Text = TextBox5.Text + dr[0].ToString() + "\n" + dr[1].ToString() + "\n"  + dr[2].ToString() + "\n"  + dr[3].ToString();
			}
		} catch (Exception x) {Response.Write(x);}
		finally {con.Close();}
	}
}
}


// 6a
-------------------------------------------------- aspx
/*< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "WebApplication8.WebForm1" % >

                      < !DOCTYPE html >

                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    < / div >
                                                    <asp: Label ID = "Label1" runat = "server" Text = "search roll o"> < / asp: Label >
                                                            <asp: TextBox ID = "TextBox1" runat = "server"> < / asp: TextBox >
                                                                    < asp: Button ID = "Button1" runat = "server" OnClick = "Button1_Click" Text = "Button" / >
                                                                            <asp: TextBox ID = "TextBox2" runat = "server" TextMode = "MultiLine"> < / asp: TextBox >
                                                                                    <asp: SqlDataSource ID = "SqlDataSource1" runat = "server" ConnectionString = "<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand = "SELECT * FROM [studentData]"> < / asp: SqlDataSource >
                                                                                            < / form >
                                                                                            < / body >
                                                                                            < / html >*/


-------------------------------------------------- cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication8 {
public partial class WebForm1 : System.Web.UI.Page {
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		try {
			string query = "select * from studentData where ROLLNO='" + TextBox1.Text + "'";
			SqlCommand cmd = new SqlCommand(query, con);
			con.Open(); SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read()) {
				TextBox2.Text += dr[0].ToString() + dr[1].ToString() + dr[2].ToString() + dr[3].ToString() + "\n";
			}
		} catch (Exception x) {Response.Write(x);}
		finally {con.Close();}
	}
}
}


// 6b

/*< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "WebApplication8.WebForm1" % >
                      < !DOCTYPE html >
                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    < / div >
                                                    <asp: Label ID = "Label1" runat = "server" Text = "search roll o"> < / asp: Label >
                                                            <asp: TextBox ID = "TextBox1" runat = "server"> < / asp: TextBox >
                                                                    < asp: Button ID = "Button1" runat = "server" OnClick = "Button1_Click" Text = "Button" / >
                                                                            <asp: SqlDataSource ID = "SqlDataSource1" runat = "server" ConnectionString = "<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand = "SELECT * FROM [studentData]"> < / asp: SqlDataSource >
                                                                                    <asp: Label ID = "Label2" runat = "server" Text = "Label"> < / asp: Label >
                                                                                            < / form >
                                                                                            < / body >
                                                                                            < / html >*/

------------------------------------------ -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8 {
public partial class WebForm1 : System.Web.UI.Page {
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		try {
			string query = "select NAME from studentData where ROLLNO='" + TextBox1.Text + "'";
			SqlCommand cmd = new SqlCommand(query, con); con.Open();
			Label2.Text = cmd.ExecuteScalar().ToString();
		} catch (Exception x) {Response.Write(x);}
		finally {con.Close();}
	}
}
}

// 7a

---------------------------------------------- aspx
/*< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "WebApplication8.WebForm1" % >

                      < !DOCTYPE html >

                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    < / div >
                                                    <asp: SqlDataSource ID = "SqlDataSource1" runat = "server" ConnectionString = "<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand = "SELECT * FROM [studentData]"> < / asp: SqlDataSource >
                                                            <asp: DropDownList ID = "DropDownList1" runat = "server" OnSelectedIndexChanged = "DropDownList1_SelectedIndexChanged">
                                                                    < / asp: DropDownList >
                                                                    <p style = "margin-left: 40px">
                                                                            <asp: Label ID = "Label1" runat = "server" Text = "Label"> < / asp: Label >
                                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
< asp: Button ID = "Button1" runat = "server" OnClick = "Button1_Click" Text = "Button" / >
                                     < / p >
                                     < / form >
                                     < / body >
                                     < / html >
*/


---------------------------------------------- cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication8 {
public partial class WebForm1 : System.Web.UI.Page {
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e) {}
	protected void Button1_Click(object sender, EventArgs e) {
		string query = "select * from studentData";
		SqlCommand cmd = new SqlCommand(query, con); con.Open();
		SqlDataReader dr = cmd.ExecuteReader();
		DropDownList1.DataSource = dr;
		DropDownList1.DataTextField = "NAME";
		DropDownList1.DataBind();
	}
	protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
		Label1.Text = DropDownList1.Text;
	}
}
}

// 7b
---------------------------------------------- aspx
/*< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "WebApplication8.WebForm1" % >
                      < !DOCTYPE html >
                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    < / div >
                                                    <asp: SqlDataSource ID = "SqlDataSource1" runat = "server" ConnectionString = "<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand = "SELECT * FROM [studentData]"> < / asp: SqlDataSource >
                                                            <p style = "margin-left: 40px">
                                                                    <asp: Label ID = "Label1" runat = "server" Text = "roll"> < / asp: Label >
                                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox1" runat = "server" style = "margin-bottom: 0px"> < / asp: TextBox >
                                      < / p >
                                      <p style = "margin-left: 40px">
                                              &nbsp;&nbsp;
< asp: Button ID = "Button1" runat = "server" OnClick = "Button1_Click" Text = "Button" / >
                                     < / p >
                                     <p style = "margin-left: 40px">
                                             <asp: Label ID = "Label2" runat = "server" Text = "Label"> < / asp: Label >
                                                     < / p >
                                                     < / form >
                                                     < / body >
                                                     < / html >*/




---------------------------------------------- cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8 {
public partial class WebForm1 : System.Web.UI.Page {
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e) {

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		string query = "select CITY from studentData where ROLLNO=" + TextBox1.Text + "";
		SqlCommand cmd = new SqlCommand(query, con);
		con.Open();

		Label2.Text = cmd.ExecuteScalar().ToString();
		con.Close();


	}

	protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}
}
}

// 7c_8


< % @ Page Language = "C#" AutoEventWireup = "true" CodeBehind = "WebForm1.aspx.cs" Inherits = "WebApplication9.WebForm1" % >

                      < !DOCTYPE html >

                      <html xmlns = "http://www.w3.org/1999/xhtml">
                                    <head runat = "server">
                                            <title> < / title >
                                            < / head >
                                            <body>
                                            <form id = "form1" runat = "server">
                                                    <div>
                                                    <asp: SqlDataSource ID = "SqlDataSource1" runat = "server"> < / asp: SqlDataSource >
                                                            < / div >
                                                            <asp: Label ID = "Label1" runat = "server" Text = "ID"> < / asp: Label >
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox1" runat = "server"> < / asp: TextBox >
                                      <p>
                                      &nbsp; < / p >
<p>
<asp: Label ID = "Label2" runat = "server" Text = "Name"> < / asp: Label >
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp: TextBox ID = "TextBox2" runat = "server"> < / asp: TextBox >
                                      < / p >
                                      < asp: Button ID = "Button1" runat = "server" Text = "view" OnClick = "Button1_Click" / >
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
< asp: Button ID = "Button2" runat = "server" Text = "insert" OnClick = "Button2_Click" / >
                                     &nbsp;&nbsp;&nbsp;&nbsp; < asp: Button ID = "Button4" runat = "server" Text = "delete" Height = "26px" OnClick = "Button4_Click" / >
                                             &nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
< asp: Button ID = "Button3" runat = "server" Text = "update" OnClick = "Button3_Click" / >
                                     <asp: GridView ID = "GridView1" runat = "server" AutoGenerateColumns = "False" DataSourceID = "SqlDataSource2">
                                             <Columns>
                                             < asp: BoundField DataField = "ID" HeaderText = "ID" SortExpression = "ID" / >
                                                     < asp: BoundField DataField = "NAME" HeaderText = "NAME" SortExpression = "NAME" / >
                                                             < / Columns >
                                                             < / asp: GridView >

                                                             <asp: SqlDataSource ID = "SqlDataSource2" runat = "server" ConnectionString = "<%$ ConnectionStrings:bulbulConnectionString %>" SelectCommand = "SELECT * FROM [tyit]"> < / asp: SqlDataSource >

                                                                     < / form >
                                                                     < / body >
                                                                     < / html >



                                                                     ----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication9
{
public partial class WebForm1 : System.Web.UI.Page
{
	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4H5MEP\SQLEXPRESS;Initial Catalog=bulbul;Integrated Security=True");
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		string query = "select * from tyit";

		SqlCommand cmd = new SqlCommand(query, con);

		con.Open();
		//SqlDataReader dr = cmd.ExecuteReader();
		GridView1.DataBind();
		con.Close();
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		string query = "insert into tyit values(" + TextBox1.Text + ",'" + TextBox2.Text + "')";
		SqlCommand cmd = new SqlCommand(query, con);

		con.Open();
		cmd.ExecuteNonQuery();
		Response.Write("data inserted successfully");
		con.Close();

	}

	protected void Button4_Click(object sender, EventArgs e)
	{
		// delll
		string query = "delete from tyit where ID=" + TextBox1.Text + "";
		SqlCommand cmd = new SqlCommand(query, con);
		con.Open();
		cmd.ExecuteNonQuery();
		Response.Write("data deleted successfully");
		con.Close();
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		string query = "update tyit set NAME='" + TextBox2.Text + "' where ID=" + TextBox1.Text + "";
		SqlCommand cmd = new SqlCommand(query, con);
		con.Open();
		cmd.ExecuteNonQuery();
		Response.Write("data updated successfully");
		con.Close();
	}
}
}

// xml
.xsl
< ?xml version = "1.0" encoding = "UTF-8"?>
                                  <xsl: stylesheet version = "1.0"
                                          xmlns: xsl = "http://www.w3.org/1999/XSL/Transform">
                                                  <xsl: template match = "/">
                                                          <html>
                                                          <body>
                                                          <h1 align = "center">Students' Basic Details</h1>
                                                                  <table border="3" align="center" >
                                                                  <tr>
                                                                  <th>Name</th>
                                                                  <th>Branch</th>
                                                                  <th>Age</th>
                                                                  <th>City</th>
                                                                  </tr>
                                                                  <xsl:for-each select="student/s">
                                                                  <tr>
                                                                  <td>
                                                                  <xsl:value-of select="name"/>
                                                                  </td>
                                                                  <td>
                                                                  <xsl:value-of select="branch"/>
                                                                  </td>
                                                                  <td>
                                                                  <xsl:value-of select="age"/>
                                                                  </td>
                                                                  <td>
                                                                  <xsl:value-of select="city"/>
                                                                  </td>
                                                                  </tr>
                                                                  </xsl:for-each>
                                                                  </table>
                                                                  </body>
                                                                  </html>
                                                                  </xsl:template>
                                                                  </xsl:stylesheet>


                                                                  ------------------ xml.xml
                                                                  <?xml version="1.0" encoding="UTF-8"?>
                                                                  <?xml-stylesheet type="text/xsl" href="XSLTFile1.xsl" ?>
                                                                  <student>
                                                                  <s>
                                                                  <name> Divyank Singh Sikarwar </name>
                                                                  <branch> CSE</branch>
                                                                  <age>18</age>
                                                                  <city> Agra </city>
                                                                  </s>
                                                                  <s>
                                                                  <name> Aniket Chauhan </name>
                                                                  <branch> CSE</branch>
                                                                  <age> 20</age>
                                                                  <city> Shahjahanpur </city>
                                                                  </s>
                                                                  <s>
                                                                  <name> Simran Agarwal</name>
                                                                  <branch> CSE</branch>
                                                                  <age> 23</age>
                                                                  <city> Buland Shar</city>
                                                                  </s>
                                                                  <s>
                                                                  <name> Abhay Chauhan</name>
                                                                  <branch> CSE</branch>
                                                                  <age> 17</age>
                                                                  <city> Shahjahanpur</city>
                                                                  </s>
                                                                  <s>
                                                                  <name> Himanshu Bhatia</name>
                                                                  <branch> IT</branch>
                                                                  <age> 25</age>
                                                                  <city> Indore</city>
                                                                  </s>
                                                                  </student>
//a) Create a web application to demonstrate Various uses and properties of SQL Data Source.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class LoginModule : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
}
protected void btnSignUp_Click(object sender, EventArgs e)
{
SqlDataSource1.InsertParameters["Username"].DefaultValue = txtUserName.Text;
SqlDataSource1.InsertParameters["Password"].DefaultValue = txtPassword.Text;
SqlDataSource1.Insert();
lblResult.Text = "User Added";
}
}
//b) Create a web application To demonstrate data binding using DetailsView and FormView control.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
namespace WebApplication1
{
public partial class WebForm1 : System.Web.UI.Page
{
SqlDataAdapter da = new SqlDataAdapter();
SqlConnection con = new SqlConnection();
SqlCommand cmd = new SqlCommand();
DataSet ds = new DataSet();
string str;
protected void Page_Load(object sender, EventArgs e)
{
con.ConnectionString = "Data
Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\SAHIL\\Documents\\Stud
ents.mdf;Inte
grated Security=True;Connect Timeout=30";
con.Open();
Label4.Text = "Connected To Server";
con.Close();
}
protected void Button1_Click(object sender, EventArgs e)
{
str = "insert into stud_mast values(" + TextBox1.Text + " , ' " + TextBox2.Text + " ' ,
"+
TextBox3.Text + ")";
con.Open();
cmd = new SqlCommand(str,con);
cmd.ExecuteNonQuery();
con.Close();
Label4.Text = " Save Successfull ";
TextBox1.Text = " ";
TextBox2.Text = " ";
TextBox3.Text = " ";
}
protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs
e)
{
}
protected void Button4_Click(object sender, EventArgs e)
{
str = "select * from stud_mast where stud_id= " + DropDownList1.Text + " ";
da = new SqlDataAdapter(str, con);
ds = new DataSet();
da.Fill(ds,"stud_mast");
TextBox1.Text = ds.Tables["stud_mast"].Rows[0]["stud_id"].ToString();
TextBox2.Text = ds.Tables["stud_mast"].Rows[0]["stud_name"].ToString();
TextBox3.Text = ds.Tables["stud_mast"].Rows[0]["phn_no"].ToString();
}
protected void Button2_Click(object sender, EventArgs e)
{
str = "update stud_mast set stud_name= ' " + TextBox2.Text + " ', phn_no= "
+TextBox3.Text+" where stud_id= "+DropDownList1.Text+" ";
con.Open();
cmd = new SqlCommand(str, con);
cmd.ExecuteNonQuery();
con.Close();
Label4.Text = " Update Successfull ";
}
protected void Button3_Click(object sender, EventArgs e)
{
str = "delete from stud_mast where stud_id=" + DropDownList1.Text + " ";
con.Open();
cmd = new SqlCommand(str, con);
cmd.ExecuteNonQuery();
con.Close();
Label4.Text = " Update Successfull ";
}}}

//9 Create a web application to demonstrate use of GridView button column and GridView events.
//Grid_view.aspx.cs:-
using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Web;
usingSystem.Web.UI;
usingSystem.Web.UI.WebControls;
usingSystem.Drawing;
public partial class grid_view : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
}
protected void GridView1_RowCommand(object sender,
GridViewCommandEventArgs e)
{
if (e.CommandName == "b1")
{
Response.Write(e.CommandName);
GridView1.SelectedRowStyle.BackColor=System.Drawing.Color.Brown;
GridView1.Rows[Convert.ToInt16(e.CommandArgument)].BackColor =
System.Drawing.Color.Blue;
}
}
}

//10 a) Create a web application to demonstrate reading and writing operation with XML.
//Default.aspx.cs:-
using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Web;
usingSystem.Web.UI;
usingSystem.Web.UI.WebControls;
usingSystem.Xml;
public partial class _Default : System.Web.UI.Page
{
protected void Button1_Click(object sender, EventArgs e)
{
XmlReader red = XmlReader.Create(@"C:\Users\Admin\Documents\Visual Studio
2010\WebSites\WebSite24\XMLFile.xml");
while (red.Read())
{
if (red.NodeType.Equals(XmlNodeType.Element))
{
string s = Label1.Text + "";
Label1.Text = s + red.Name;
}
}
red.Close();
}
protected void Button2_Click(object sender, EventArgs e)
{
XmlWriterSettings set = new XmlWriterSettings();
set.Indent = true;
XmlWriterwr = XmlWriter.Create(@"C:\Users\Admin\Documents\Visual Studio
2010\WebSites\WebSite24\XMLFile3.xml",set);
wr.WriteStartDocument();
wr.WriteComment("EXAMPLE OF WRITE A XML DOCUMENT");
wr.WriteStartElement("student");
wr.WriteEndElement();
}
}

//11) Programs to create and use DLL
//Class1.cs:-
using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Text;
namespace ClassLibrary5
{
publicclassClass1
{
publicint add(int a, int b)
{
int c = a + b;
return c;
}
}
}
________________________
//Consoleapplication5.cs:-
using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Text;
namespace ConsoleApplication5
{
classProgram
{
staticvoid Main(string[] args)
{
ClassLibrary5.Class1 c = newClassLibrary5.Class1();
int t = c.add(1, 2);
Console.WriteLine("addition={0}", t);
Console.ReadKey();
Page 90 of 91TYIT ADVANCED WEB PROGRAMMING MANUAL
K.M.AGRAWAL COLLEGE
}
}
}
