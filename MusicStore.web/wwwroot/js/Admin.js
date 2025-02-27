document.addEventListener("DOMContentLoaded", function () {
    // Add event listeners for delete buttons
    document.querySelectorAll(".delete-btn").forEach(button => {
        button.addEventListener("click", function () {
            let row = this.parentNode.parentNode;
            row.parentNode.removeChild(row);
        });
    });

    // Add event listeners for role changes
    document.querySelectorAll(".role-select").forEach(select => {
        select.addEventListener("change", function () {
            alert("User role changed to: " + this.value);
        });
    });
});
