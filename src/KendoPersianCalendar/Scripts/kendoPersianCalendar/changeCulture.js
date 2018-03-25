/*!
* Change culture for Kendo UI v2018.1.221 (http://www.NasrSoft.com)                                                                                                                                               
 * Copyright 2018 NasrSoft Group. All rights reserved.
 *
 * -------------------------------------------------------
 * Develop by Mahdi Nosratian
 * Email: Mahdi.Nosratian@gmail.com
 * -------------------------------------------------------
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       

*/
if (localStorageSupport()) {
    var localIsPersianCulture = localStorage.getItem("isPersianCulture");
    if (localIsPersianCulture != null) {
        isPersianCulture = localStorage.getItem("isPersianCulture");
    } else {
        localStorage.setItem("isPersianCulture", isPersianCulture);
    }
}

if (isPersianCulture == 'true' || isPersianCulture == true) {
    kendo.culture("fa-IR");
} else {
    kendo.culture("en-US");
}

// check if browser support HTML5 local storage
function localStorageSupport() {
    return (('localStorage' in window) && window['localStorage'] !== null);
}

