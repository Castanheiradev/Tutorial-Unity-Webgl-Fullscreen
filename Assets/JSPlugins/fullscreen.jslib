mergeInto(LibraryManager.library, {

  ToggleFullScreen: function () {
    let canvas = document.getElementById("unity-canvas");
    let isCanvasFullscreen = document.fullscreenElement === canvas;

    if(isCanvasFullscreen)
    {
        document.exitFullscreen();
    }
    else {
        canvas.requestFullscreen();
    }
  },

  RegisterFullscreenEvent: function() {
    document.addEventListener("fullscreenchange", function(e) {
        if(document.fullscreenElement) {
            SendMessage("Fullscreen", "SetWindowedIcon");
        }
        else {
            SendMessage("Fullscreen", "SetFullscreenIcon");
        }
    });
  }
});