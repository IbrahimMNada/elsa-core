using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elsa.Activities.Command.Activities;
using Elsa.Activities.Command.Providers;
using Elsa.Extensions;
using Elsa.Features.Services;
using Elsa.Workflows;
using Elsa.Workflows.Management.Features;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Activities.Command.Extensions;
public static class CommandActivitiesExtensions
{
    public static IModule AddCommandActivities(this IModule module, IServiceCollection serviceDescriptors)
    {
        serviceDescriptors.AddScoped<IPropertyUIHandler, WorkflowCommandProvider>();
        module.AddActivitiesFrom<CommandActivity>();
        return module;
    }
}
