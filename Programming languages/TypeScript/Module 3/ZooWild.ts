/// <reference path="ZooAnimals.ts" />

namespace Zoo {
    export class Reptile implements Animal { //note that we need the *export* here to be able to acccess this class and instantiate objects of the Reptile type
		 skinType ="scales";
        isMammal(){
            return false;
        }
    }
}