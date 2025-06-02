function showSection(sectionId) {
  const sections = document.querySelectorAll("main section");
  sections.forEach(sec => sec.classList.add("hidden"));

  const selected = document.getElementById(sectionId);
  if (selected) selected.classList.remove("hidden");
}
