const coloer = document.querySelector('#colorPicker');

function func() {
    document.body.style.backgroundColor = coloer.value;
}

coloer.addEventListener('input',func);