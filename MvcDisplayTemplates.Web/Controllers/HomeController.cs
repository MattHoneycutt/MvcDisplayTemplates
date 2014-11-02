using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcDisplayTemplates.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new SampleModel());
        }
    }

	public class SampleModel
	{
		[DataType(DataType.Text)]
		public string StringValue { get; set; }
		public int IntValue { get; set; }
		public bool BoolValue { get; set; }
		public decimal DecimalValue { get; set; }
		[EmailAddress]
		public string EmailAddress { get; set; }
		[HiddenInput]
		public string HiddenValue { get; set; }
		[DataType(DataType.Html)]
		public string HtmlValue { get; set; }
		[Url]
		public string UrlValue { get; set; }

		public bool NonNullBool { get; set; }
		public bool? NullableBool { get; set; }

		public string[] MyStringCollection { get; set; }

		public double[] MyDoubleCollection { get; set; }

		public SampleModel()
		{
			StringValue = "String Value";
			IntValue = 54321;
			BoolValue = true;
			DecimalValue = 12345.6789m;
			EmailAddress = "test@user.com";
			HiddenValue = "You can't see me!";
			HtmlValue = "<i>I'm HTML!</i>";
			UrlValue = "http://trycatchfail.com/blog";
			NonNullBool = true;
			NullableBool = true;

			MyStringCollection = new[] {"Value 1", "Value 2", "Value 3"};

			MyDoubleCollection = new[] {1.1, 2.2, 3.3};
		}
	}
}
