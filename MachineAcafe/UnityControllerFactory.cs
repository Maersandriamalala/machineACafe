using Castle.Windsor;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace MachineAcafe
{
    public class UnityControllerFactory : IControllerFactory
    {
        public IController CreateController
    (RequestContext requestContext, string controllerName)
        {
            IContainerAccessor containerAccessor =
                requestContext.HttpContext.ApplicationInstance as IContainerAccessor;

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var controllerTypes = from t in currentAssembly.GetTypes()
                                  where t.Name.Contains(controllerName + "Controller")
                                  select t;

            if (controllerTypes.Count() > 0)
            {
                return containerAccessor.Container.Resolve
                (controllerTypes.First()) as IController;
            }
            return null;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            controller = null;
        }
    }
}