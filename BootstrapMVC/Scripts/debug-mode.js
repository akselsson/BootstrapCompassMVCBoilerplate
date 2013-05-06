/*global LIB */

LIB.debug = true;

// Redefine log in debug mode
LIB.log = function (msg, type) {
    'use strict';
    if (typeof type === 'undefined') {
        type = 'info';
    }
    if (window.console) {
        window.console[type](msg);
    }
};
