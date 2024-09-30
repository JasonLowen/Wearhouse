const addCategoryButton = document.querySelectorAll('[data-modal-target]')
const closeAddCategoryButton = document.querySelectorAll('[data-close-button]')
const overlay = document.getElementById('overlay')

addCategoryButton.forEach(button => {
    button.addEventListener('click', () => {
        const modal = document.querySelector(button.dataset.modalTarget)
        open(modal)
    })
})

closeAddCategoryButton.forEach(button => {
    button.addEventListener('click', () =>{
        const modal = button.closest('.modal')
        close(modal)
    })
})

closeAddCategoryButton.forEach(button => {
    button.addEventListener('click', () =>{
        const modal = button.closest('.modalDel')
        close(modal)
    })
})

overlay.addEventListener('click', () => {
    const modals = document.querySelectorAll('.modal.active')
    modals.forEach(modal => {
        close(modal)
    })
})

overlay.addEventListener('click', () => {
    const modals = document.querySelectorAll('.modalDel.active')
    modals.forEach(modal => {
        close(modal)
    })
})

function open(modal) {
    if(modal == null) return
    modal.classList.add('active')
    overlay.classList.add('active')
}

function close(modal){
    if(modal == null) return
    modal.classList.remove('active')
    overlay.classList.remove('active')
}