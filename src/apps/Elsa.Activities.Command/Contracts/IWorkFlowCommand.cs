using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elsa.Mediator.Contracts;

namespace Elsa.Activities.Command.Contracts;
public abstract class IWorkFlowCommand : ICommand
{
    public string WorkflowIntanceId { get; internal set; }
    public string WorkflowContextId { get; internal set; }
    public string WorkflowCorrelationId { get; internal set; }
    public Dictionary<string, object> WrokflowInputs { get; internal set; }
}
