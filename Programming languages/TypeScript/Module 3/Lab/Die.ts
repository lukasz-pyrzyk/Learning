class Die {
    div : Element;
    constructor(div : Element) {
        this.div = div;
    }

    public ChangeText(text : string){
        let elem = this.div as HTMLElement;
        elem.innerText = text;
    }
}

export default Die;