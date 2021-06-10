using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Business.Interfaces;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;

namespace Udemy.ToDoAppNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;
        private readonly IMapper _mapper;

        public HomeController(IWorkService workService, IMapper mapper)
        {
            _workService = workService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _workService.GetAll());

        }

        public IActionResult Create()
        {
            return View(new WorkCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
            if (ModelState.IsValid)
            {
                await _workService.Create(dto);
                return RedirectToAction("Index");
            }

            return View(dto);
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(_mapper.Map<WorkUpdateDto>(await _workService.GetById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto)
        {
            if (ModelState.IsValid)
            {
                await _workService.Update(dto);
                return RedirectToAction("Index");

            }
            return View(dto);
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _workService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
