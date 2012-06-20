function Render() {
    this.Button = Button;

    function Button(buttonId, value, name, _class) {
        var button = '<input type="button" id="' + buttonId + '" value="' + value + '" name="'+ name +'" class="'+ _class +'" />';
        return button;
    }
}