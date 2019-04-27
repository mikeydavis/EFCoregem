export default class lib1 {

    constructor(){
        this.text = "Data from getText function in lib dependency";
    }

    getText(){
        return "Data from getText function in lib dependency";
    }

    getDataBind(){
        return this.text;
    }

}