document.getElementById('toggle-password').addEventListener('click', function () {
    // Toggle the icon and word
    const icon = document.getElementById('toggle-icon');
    const word = document.getElementById('word-toggle');
    const passwordInput = document.getElementById('password');

    if (icon.classList.contains('bi-eye')) {
        // Change the icon to 'eye-slash' and the word to 'Hide'
        icon.classList.replace('bi-eye', 'bi-eye-slash');
        word.textContent = 'Hide';

        // Show the password
        passwordInput.type = 'text';
    } else {
        // Change the icon back to 'eye' and the word to 'Show'
        icon.classList.replace('bi-eye-slash', 'bi-eye');
        word.textContent = 'Show';

        // Hide the password
        passwordInput.type = 'password';
    }
});