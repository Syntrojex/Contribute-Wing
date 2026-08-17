const inputbox = document.getElementById('input-box');
const listcontainer = document.getElementById('list=container');

function myfunction() {
    if (inputbox.value === "") {
        alert('you must write something!')
    }
    else {
        let li = document.createElement('li');
        li.innerHTML = inputbox.value;
        listcontainer.appendChild(li);
        let span = document.createElement('span');
        span.innerHTML = "\u00d7"
        li.appendChild(span)
    }
    inputbox.value = ""
}

listcontainer.addEventListener(function (abc) {
    if (abc.target.tagName === "li") {
        abc.target.classList.toggle('Checked')
    }
    else if (abc.target.tagName === "span") {
        abc.target.parentElement.remove()
    }

}, false)





