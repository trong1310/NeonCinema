window.sseHandler = {
    startSSE: function (url, dotNetObject) {
        const eventSource = new EventSource(url);

        eventSource.onmessage = function (event) {
            const data = JSON.parse(event.data);
            dotNetObject.invokeMethodAsync('OnSeatsUpdated', data);
        };

        eventSource.onerror = function () {
            console.error('Error occurred with SSE connection.');
            eventSource.close();
        };

        return eventSource;
    },
    stopSSE: function (eventSource) {
        if (eventSource) {
            eventSource.close();
        }
    }
};