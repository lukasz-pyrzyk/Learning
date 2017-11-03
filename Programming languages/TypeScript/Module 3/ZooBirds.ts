/// <reference path="ZooAnimals.ts" />
namespace Zoo {
    export class Bird implements Animal {   //note that we need the *export* here to be able to acccess this class and instantiate objects of the Bird type
		skinType = "feather";
        isMammal() {
            return false;
        }
    }
}