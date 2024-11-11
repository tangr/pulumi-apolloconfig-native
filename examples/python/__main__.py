import pulumi
import pulumi_apolloconfig as apolloconfig

my_random_resource = apolloconfig.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
