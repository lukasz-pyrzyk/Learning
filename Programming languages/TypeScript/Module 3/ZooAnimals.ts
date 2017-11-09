namespace Zoo {	
    interface Animal { //note that we do not need the *export* here since this interface will only be accessible only by entities from within the Zoo namespace
		skinType: string;
        isMammal(): boolean;
    }
}
