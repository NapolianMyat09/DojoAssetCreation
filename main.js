function zippedFile(){
    var link = document.createElement("a");
    link.href = "https://github.com/NapolianMyat09/DojoAssetCreation/raw/refs/heads/main/DojoAssetCreationBuild.zip";
    link.download = "DojoAssetCreationBuild.zip";
    link.click();
    document.body.removeChild(link);
}