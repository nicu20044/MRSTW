document.addEventListener('DOMContentLoaded', function() {
    const beatsTable = document.querySelector('#beatsTable tbody');
    let beats = []; // Ar trebui să fie populat de la backend

    // Simulare adăugare beat (fără backend)
    document.getElementById('addBeatForm').addEventListener('submit', function(e) {
        e.preventDefault();
        const formData = new FormData(e.target);
        const newBeat = {
            title: formData.get('title'),
            artist: formData.get('artist'),
            genre: formData.get('genre'),
            price: formData.get('price')
        };
        beats.push(newBeat);
        updateBeatsTable();
        e.target.reset(); // Resetează formularul
    });

    function updateBeatsTable() {
        beatsTable.innerHTML = '';
        beats.forEach(beat => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${beat.title}</td>
                <td>${beat.artist}</td>
                <td>${beat.genre}</td>
                <td>${beat.price}</td>
                <td><button onclick="deleteBeat(${beats.indexOf(beat)})">Șterge</button></td>
            `;
            beatsTable.appendChild(row);
        });
    }

    // Simulare ștergere beat (fără backend)
    window.deleteBeat = function(index) {
        if (confirm("Sigur vrei să ștergi acest beat?")) {
            beats.splice(index, 1);
            updateBeatsTable();
        }
    };


    
    updateBeatsTable();
});