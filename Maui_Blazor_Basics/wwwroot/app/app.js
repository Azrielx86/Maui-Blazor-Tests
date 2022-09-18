const audio = new Audio();
let playing = false;
let currentId = undefined;

function playAudio(audioSrc, songId) {
    if (audio.src === undefined && songId === undefined) {
        audio.src = audioSrc;
        currentId = songId;
    }

    if (audio.src !== audioSrc && currentId !== songId) {
        if (currentId !== undefined)
            document.getElementById(currentId).classList.remove("border-primary");

        audio.pause();
        playing = false;
        audio.src = audioSrc;
        currentId = songId;
    }
    
    if (playing) {
        document.getElementById(currentId).classList.remove("border-primary");
        audio.pause();
        playing = false;
    } else {
        document.getElementById(currentId).classList.add("border-primary");
        audio.play();
        playing = true;
    }
}

function stopAudio() {
    audio.pause();
    currentId = undefined;
    audio.src = undefined;
}