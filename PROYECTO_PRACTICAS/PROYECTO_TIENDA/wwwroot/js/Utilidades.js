//Formato fecha
function pad(number) {
    if (number < 10) {
        return '0' + number;
    }
    return number;
}
Date.prototype.toISO = function () {
    let Fecha = Date.now()
    return Fecha.getUTCFullYear() +
        '-' + pad(Fecha.getUTCMonth() + 1) +
        '-' + pad(Fecha.getUTCDate()) /* +
      'T' + pad(this.getUTCHours()) +
      ':' + pad(this.getUTCMinutes()) +
      ':' + pad(this.getUTCSeconds()) +
      '.' + (this.getUTCMilliseconds() / 1000).toFixed(3).slice(2, 5) +
      'Z' */;
};

function ModalFunction(DivModal) {
    if (DivModal.style.opacity == 0) {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 1;
        DivModal.style.pointerEvents = "all";


    } else {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 0;
        DivModal.style.pointerEvents = "none";
    }

}