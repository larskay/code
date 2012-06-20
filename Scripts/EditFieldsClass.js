function EditFields(id, caption, value) {
    this.RenderFields = RenderFields;

    function RenderFields(type) {
        for (var t in type) {
            switch (type) {
                case 'PageName': new PageList().RenderPageName(id, caption, value);
                    break;
                case 'String<=255': new PageList().RenderStringLess255(id, caption, value);
                    break;
                case 'String>=255': new PageList().RenderStringGreater255(id, caption, value);
                    break;
                case 'GMSList': new PageList().RenderGMSList(id, caption, value);
                    break;
                case 'GMSRadio': new PageList().RenderGMSRadio(id, caption, value);
                    break;
                case 'GMSCheckList': new PageList().RenderGMSCheckList(id, caption, value);
                    break;
                case 'GMSDate': new PageList().RenderGMSDate(id, caption, value);
                    break;
                case 'GMSLabel': new PageList().RenderGMSLabel(id, caption, value);
                    break;
                case 'GMSUerList': new PageList().RenderGMSUserList(id, caption, value);
                    break;
                case 'Heltall': new PageList().RenderHeltall(id, caption, value);
                    break;
            }
        }
    }











}