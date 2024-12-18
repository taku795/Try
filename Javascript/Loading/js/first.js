window.addEventListener('load',func);

function func() {
    setTimeout(() => {
        const loading = document.getElementById('my-spinner');
        loading.classList.add('loaded');
    }, 2 * 1000);
}