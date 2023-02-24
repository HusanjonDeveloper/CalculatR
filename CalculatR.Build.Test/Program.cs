using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

var githubPipline = new GithubPipeline
{
    Name = "CalculatR",
    OnEvents = new Events
    {
        PullRequest = new PullRequestEvent
        {
            Branches = new string[] { "Main" }
        },

        Push = new PushEvent
        { Branches = new string[] { "Manin" } }
    },
    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.Windows2022,

            Steps = new List<ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.GithubTask>
                  {
                     new CheckoutTaskV2
                     {
                         Name = "Chesking"
                     },
                     new SetupDotNetTaskV1
                     {
                         TargetDotNetVersion = new TargetDotNetVersion
                         {

                              DotNetVersion = " 7.0.200"
                         }
                     },

                     new RestoreTask
                     {
                         Name = "Restorinig.."
                     },
                     new DotNetBuildTask
                     {
                         Name = "Building"
                     },
                     new TestTask
                     {
                         Name= "Test"
                     }
                  }
        }
    }
};

var clint = new ADotNetClient();
clint.SerializeAndWriteToFile(
    githubPipline,
    path: "../../../../.github/workflows/build.yml");