var mmtScripts = {};

mmtScripts.setSessionStorage = function (key, data) {
    sessionStorage.setItem(key, data);
}

mmtScripts.getSessionStorage = function (key) {
    return sessionStorage.getItem(key);
}