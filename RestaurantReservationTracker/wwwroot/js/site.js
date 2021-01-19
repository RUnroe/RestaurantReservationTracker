// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const toggleReservationSection = senderID => {
    console.log(senderID);
    reservationDiv = document.querySelector(`[data-id="${senderID}"]`);
    console.log(reservationDiv);
    reservationDiv.classList.contains("hidden") ? collapseReservationSection(reservationDiv) : expandReservationSection(reservationDiv);
}
const collapseReservationSection = reservationDiv => {
    reservationDiv.classList.remove("hidden");
    reservationDiv.getElementsByClassName("toggleDetailsBtn")[0].innerHTML = "&#8743;";
}

const expandReservationSection = reservationDiv => {
    reservationDiv.classList.add("hidden");
    reservationDiv.getElementsByClassName("toggleDetailsBtn")[0].innerHTML = "&#8744;";


}
