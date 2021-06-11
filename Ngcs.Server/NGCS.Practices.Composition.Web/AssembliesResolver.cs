using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Dispatcher;
using Ngcs.Practices.Composition;

namespace NGCS.Practices.Composition.Web
{
    public class AssembliesResolver : AssembliesResolverBase, IAssembliesResolver
    {
	    public AssembliesResolver(
		    ICompositionModulesProvider compositionModulesProvider)
		    : base(compositionModulesProvider)
	    {
	    }

	    protected override IEnumerable<Assembly> GetRootAssemblies() => (IEnumerable<Assembly>)new Assembly[1]
	    {
		    AssembliesResolver.GetEntryAssembly()
	    };

	    ICollection<Assembly> IAssembliesResolver.GetAssemblies() => (ICollection<Assembly>)this.GetAssemblies().ToList<Assembly>();

	    private static Assembly GetEntryAssembly()
	    {
		    if (HttpContext.Current == null || HttpContext.Current.ApplicationInstance == null)
			    return (Assembly)null;
		    Type type = HttpContext.Current.ApplicationInstance.GetType();
		    while (type != (Type)null && type.BaseType != (Type)null && type.BaseType.Name != "HttpApplication")
			    type = type.BaseType;
		    return type == (Type)null ? (Assembly)null : type.Assembly;
	    }
    }
}


