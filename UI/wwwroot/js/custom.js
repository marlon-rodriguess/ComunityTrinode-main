function binarynumbers() {
    var aboutSection = document.querySelector('.about');
    var numerosCaindo = document.querySelector('.numeros-caindo');
    
    if (aboutSection && numerosCaindo) {
        numerosCaindo.style.top = aboutSection.offsetTop + 'px';
    }
}