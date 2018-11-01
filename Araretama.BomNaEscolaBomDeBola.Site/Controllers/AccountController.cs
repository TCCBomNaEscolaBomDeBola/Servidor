using Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Context;
using Araretama.BomNaEscolaBomDeBola.Domain;
using Araretama.BomNaEscolaBomDeBola.Repository.Entity;
using AraretamaRepositoy;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Araretama.BomNaEscolaBomDeBola.Site.Controllers
{
    public class AccountController : Controller
    {
        private DbContext _Context;

        private IAraretamaCommonRepository<Voluntario, int> _repository = new VoluntarioRepository(new BomNaEscolaBomDeBolaDbContext());
        // GET: Account
        public ActionResult Login(string returnURL)
        {
            /*Recebe a url que o usuário tentou acessar*/
            ViewBag.ReturnUrl = returnURL;
            return View();
        }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(Voluntario login, string returnUrl)
    {
        if (ModelState.IsValid) {
            var vLogin = _Context.Set<Voluntario>().Where(p => p.Senha == login.Senha & p.Login == login.Login).FirstOrDefault();      
            if (vLogin != null)
            {
                       
                if (Equals(vLogin.Senha, login.Senha))
                {
                    FormsAuthentication.SetAuthCookie(vLogin.Login, false);
                    if (Url.IsLocalUrl(returnUrl)
                    && returnUrl.Length > 1
                    && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//")
                    && returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }

                    Session["Nome"] = vLogin.Nome;

                    return RedirectToAction("Index", "Home");
                }    
                else
                {
                    ModelState.AddModelError("", "Senha informada Inválida!!!");
                    return View();
                }
            }
                   
        }                                                                        
        else
        {
            ModelState.AddModelError("", "Login informado inválido!!!");
            return View();
        }
            return View();
        }
       
   

    }
}