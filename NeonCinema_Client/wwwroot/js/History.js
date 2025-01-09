
function downloadFile(fileName, bytes, mimeType) {
    const blob = new Blob([new Uint8Array(bytes)], { type: mimeType });
    const link = document.createElement('a');
    link.href = URL.createObjectURL(blob);
    link.download = fileName;
    link.click();
    URL.revokeObjectURL(link.href); // Clean up URL object
}

   



