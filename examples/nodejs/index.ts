import * as pulumi from "@pulumi/pulumi";
import * as apolloconfig from "@pulumi/apolloconfig";

const myRandomResource = new apolloconfig.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
