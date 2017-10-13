public class HomeController: controller
{
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
  
}
