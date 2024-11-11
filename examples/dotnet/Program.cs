using System.Collections.Generic;
using System.Linq;
using Pulumi;
using apolloconfig = Pulumi.apolloconfig;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new apolloconfig.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

