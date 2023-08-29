const bioName = document.getElementById("name");
const bioText = document.getElementById("bio_text");
const bioImage = document.getElementById("image");

const changeTextBtn = document.getElementById("changeTextBtn");
const changeStyleBtn = document.getElementById("changeStyleBtn");

const bioAboutMe = document.getElementById("aboutMe")
alert(bioAboutMe.textContent)


changeTextBtn.addEventListener("click", () => {
    bioName.textContent = "My name => Vlad";
    bioText.textContent = "I am fond of programming and boxing.";
});

changeStyleBtn.addEventListener("click", () => {
    bioImage.style.border = "3px solid rgb(17, 0, 255)";
    bioText.style.fontSize = "20px";
    bioText.style.padding = "10px";
    bioText.style.borderRadius = "5px";
    bioText.style.textAlign = "center";
    bioText.style.border = "1px solid rgb(17, 0, 255)";
    bioName.style.textAlign = "center";
});
