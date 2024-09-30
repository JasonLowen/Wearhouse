const openAdd = document.querySelectorAll('.openAdd')
const popUpAdd = document.querySelector('.modalAdd')

const openEdit = document.querySelectorAll('.openEdit')
const popUpEdit = document.querySelector('.modalEdit')

const openDelete = document.querySelectorAll('.openDelete')
const popUpDelete = document.querySelector('.modalDelete')

const overlay = document.getElementById('overlay')
const exit = document.querySelectorAll('.close')

for(let i = 0; i < openAdd.length; i++){
    openAdd[i].addEventListener("click", () => {
        popUpAdd.classList.toggle('active')
        overlay.classList.toggle('active')
    })
}

for(let i = 0; i < openEdit.length; i++){
    openEdit[i].addEventListener("click", () => {
        popUpEdit.classList.toggle('active')
        overlay.classList.toggle('active')
    })
}

for(let i = 0; i < openDelete.length; i++){
    openDelete[i].addEventListener("click", () => {
        popUpDelete.classList.toggle('active')
        overlay.classList.toggle('active')
    })
}

for(let i = 0; i < exit.length; i++){
    exit[i].addEventListener("click", () => {
        popUpAdd.classList.remove('active')
        popUpEdit.classList.remove('active')
        popUpDelete.classList.remove('active')
        overlay.classList.remove('active')
    })
}

const closeAdd = document.querySelector('.modalAdd.active')
const closeEdit = document.querySelectorAll('.modalEdit.active')
const closeDelete = document.querySelectorAll('.modalDelete.active')

for(let i = 0; i < closeAdd.length; i++){
    closeAdd[i].addEventListener("click", () => {
        popUpAdd.classList.remove('active')
        popUpEdit.classList.remove('active')
        popUpDelete.classList.remove('active')
        overlay.classList.remove('active')
    })
}

for(let i = 0; i < closeEdit.length; i++){
    closeEdit[i].addEventListener("click", () => {
        popUpAdd.classList.remove('active')
        popUpEdit.classList.remove('active')
        popUpDelete.classList.remove('active')
        overlay.classList.remove('active')
    })
}

for(let i = 0; i < closeDelete.length; i++){
    closeDelete[i].addEventListener("click", () => {
        popUpAdd.classList.remove('active')
        popUpEdit.classList.remove('active')
        popUpDelete.classList.remove('active')
        overlay.classList.remove('active')
    })
}

// overlay.addEventListener('click', () =>{
//     const addClose = document.querySelectorAll('.modalAdd.active')
//     addClose.forEach(button => {
//         button.classList.remove('active')
//         overlay.classList.remove('active')
//     })
//     const editClose = document.querySelectorAll('.modalEdit.active')
//     editClose.forEach(button => {
//         button.classList.remove('active')
//         overlay.classList.remove('active')
//     })
//     const delClose = document.querySelectorAll('.modalDelete.active')
//     delClose.forEach(button => {
//         button.classList.remove('active')
//         overlay.classList.remove('active')
//     })
// })