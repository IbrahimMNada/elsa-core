using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elsa.Activities.Command.Activities;
using Elsa.Extensions;
using Elsa.Features.Services;
using Elsa.Workflows.Management.Features;

namespace Elsa.Activities.Command.Extensions;
public static class CommandActivitiesExtensions
{
    public static IModule AddCommandActivities(this IModule module)
    {
        return module.UseWorkflowManagement(delegate (WorkflowManagementFeature management)
        {
            management.AddActivitiesFrom<CommandActivity>();
        });
    }
}
