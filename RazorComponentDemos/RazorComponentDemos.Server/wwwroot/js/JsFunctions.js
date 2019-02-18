window.jsFunctions = {
    checkRunningState: function (dotnetHelper) {
        dotnetHelper.invokeMethodAsync('CheckRunningState');
    }
};